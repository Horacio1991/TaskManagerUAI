using System.Transactions;
using Entity;
using DAL;
using System.Text.RegularExpressions;

namespace BLL
{
    public class UsuarioBLL
    {
        private readonly UsuarioDAL _usuarioDal;
        private List<Usuario> _usuariosEnMemoria = new List<Usuario>();

        public UsuarioBLL()
        {
            _usuarioDal = new UsuarioDAL();
        }

        public Usuario ValidarUsuario(string email, string password) //Para el login
        {
            try
            {
                ValidarEmail(email);
                ValidarCampoVacio(password, "contraseña", "CONTRASEÑA");

                return _usuarioDal.ValidarUsuario(email, password);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la validación del usuario: " + ex.Message);
            }
        }

        public List<Usuario> ObtenerUsuariosPorSector(int sectorId) // Para cargar empleados en el ComboBox de las tareas
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

        public void GuardarUsuarioEnMemoria(Usuario usuario)
        {
            _usuariosEnMemoria.Add(usuario);
        }

        public void ConfirmarUsuarios()
        {
            // Validar que todos los usuarios en memoria tengan los campos correctamente llenos
            foreach (var usuario in _usuariosEnMemoria)
            {
                try
                {
                    ValidarDatosUsuario(usuario, esModificacion: false);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al confirmar usuarios: {ex.Message}. Ningún usuario ha sido agregado.");
                }
            }

            using (TransactionScope transaction = new TransactionScope())
            {
                foreach (var usuario in _usuariosEnMemoria)
                {
                    _usuarioDal.AgregarUsuario(usuario);
                }
                transaction.Complete();
            }

            _usuariosEnMemoria.Clear();
        }

        public void ModificarUsuarioPorEmail(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Email))
                throw new ArgumentException("El email no puede estar vacío.");

            if (!string.IsNullOrEmpty(usuario.Nombre) || !string.IsNullOrEmpty(usuario.Password))
            {
                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        _usuarioDal.ModificarUsuarioPorEmail(usuario);
                        transaction.Complete(); // Completa la transacción si no hay errores
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al modificar el usuario: " + ex.Message);
                    }
                }
            }
            else
            {
                throw new ArgumentException("No se ha proporcionado ningún dato para modificar.");
            }
        }


        public void EliminarUsuarioConTareas(string email)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    _usuarioDal.EliminarUsuarioConTareas(email);
                    transaction.Complete(); // Completa la transacción si no hay errores
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el usuario y sus tareas en la BLL: " + ex.Message);
                }
            }
        }


        private void ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || email == "EMAIL")
                throw new Exception("El email no puede estar vacío o ser inválido.");

            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, patronEmail))
                throw new Exception("El formato del email no es válido.");
        }

        private void ValidarCampoVacio(string campo, string nombreCampo, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(campo) || campo == placeholder)
                throw new Exception($"El campo {nombreCampo} no puede estar vacío o tener el texto '{placeholder}'.");
        }

        private void ValidarDatosUsuario(Usuario usuario, bool esModificacion)
        {
            const string placeholderNombre = "NOMBRE";
            const string placeholderPassword = "CONTRASEÑA";

            ValidarCampoVacio(usuario.Nombre, "nombre", placeholderNombre);
            ValidarEmail(usuario.Email);

            if (!esModificacion)
            {
                ValidarCampoVacio(usuario.Password, "contraseña", placeholderPassword);
            }
        }
    }
}
