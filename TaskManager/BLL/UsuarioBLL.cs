using Entity;
using DAL;
using System.Text.RegularExpressions;

namespace BLL
{
    public class UsuarioBLL
    {
        private readonly UsuarioDAL _usuarioDal;

        public UsuarioBLL()
        {
            _usuarioDal = new UsuarioDAL();
        }

        // Método para validar si las credenciales son correctas
        public Usuario ValidarUsuario(string email, string password)
        {
            try
            {
                // Validar email y contraseña antes de enviar los datos a la DAL
                ValidarEmail(email);
                ValidarCampoVacio(password, "contraseña", "CONTRASEÑA");

                // Llamada a la DAL para validar las credenciales
                return _usuarioDal.ValidarUsuario(email, password);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la validación del usuario: " + ex.Message);
            }
        }

        // Obtener la lista de usuarios por sector (para jefe de sector)
        public List<Usuario> ObtenerUsuariosPorSector(int sectorId)
        {
            try
            {
                if (sectorId <= 0)
                    throw new Exception("El ID del sector debe ser un valor positivo.");

                return _usuarioDal.ObtenerUsuariosPorSector(sectorId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener usuarios por sector: " + ex.Message);
            }
        }

        // Método para agregar un usuario lo usará el administrador
        public void AgregarUsuario(Usuario usuario)
        {
            try
            {
                // Validar los datos del usuario para agregarlo
                ValidarDatosUsuario(usuario, esModificacion: false);
                _usuarioDal.AgregarUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el usuario: " + ex.Message);
            }
        }

        // Método para modificar un usuario lo usará el administrador
        public void ModificarUsuarioPorEmail(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Email))
                throw new ArgumentException("El email no puede estar vacío.");

            // Modificar solo si hay datos válidos en nombre o contraseña
            if (!string.IsNullOrEmpty(usuario.Nombre) || !string.IsNullOrEmpty(usuario.Password))
            {
                try
                {
                    _usuarioDal.ModificarUsuarioPorEmail(usuario);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al modificar el usuario: " + ex.Message);
                }
            }
            else
            {
                throw new ArgumentException("No se ha proporcionado ningún dato para modificar.");
            }
        }



        // Eliminar usuario aunque tenga tareas asociadas (lo usará el administrador)
        public void EliminarUsuarioConTareas(string email)
        {
            try
            {
                _usuarioDal.EliminarUsuarioConTareas(email);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el usuario y sus tareas en la BLL: " + ex.Message);
            }
        }

        // Método para validar el formato del email usando expresiones regulares
        private void ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || email == "EMAIL")
                throw new Exception("El email no puede estar vacío o ser inválido.");

            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, patronEmail))
                throw new Exception("El formato del email no es válido.");
        }

        // Método para validar que un campo no esté vacío o tenga el placeholder como valor
        private void ValidarCampoVacio(string campo, string nombreCampo, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(campo) || campo == placeholder)
                throw new Exception($"El campo {nombreCampo} no puede estar vacío o tener el texto '{placeholder}'.");
        }

        // Método para validar los datos al agregar un usuario
        private void ValidarDatosUsuario(Usuario usuario, bool esModificacion)
        {
            // Placeholder que usa la interfaz
            const string placeholderNombre = "NOMBRE";
            const string placeholderPassword = "CONTRASEÑA";

            // Validar campos básicos
            ValidarCampoVacio(usuario.Nombre, "nombre", placeholderNombre);
            ValidarEmail(usuario.Email);

            // Si estamos agregando un nuevo usuario, la contraseña no puede estar vacía o tener el placeholder
            if (!esModificacion)
            {
                ValidarCampoVacio(usuario.Password, "contraseña", placeholderPassword);
            }
        }

        // Método para validar los datos al modificar un usuario
        private void ValidarDatosUsuarioModificacion(Usuario usuario)
        {
            const string placeholderNombre = "NOMBRE";
            const string placeholderPassword = "CONTRASEÑA";

            // Validar nombre (obligatorio)
            ValidarCampoVacio(usuario.Nombre, "nombre", placeholderNombre);

            // Validar email siempre
            ValidarEmail(usuario.Email);

            // Si la contraseña está presente, validarla (no es obligatorio modificarla)
            if (!string.IsNullOrWhiteSpace(usuario.Password) && usuario.Password != placeholderPassword)
            {
                ValidarCampoVacio(usuario.Password, "contraseña", placeholderPassword);
            }
        }

        public List<Usuario> ObtenerUsuariosNoAdministradores()
        {
            return _usuarioDal.ObtenerUsuariosNoAdministradores();
        }

        


    }
}
