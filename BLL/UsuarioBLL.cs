using System;
using System.Collections.Generic;
using System.Transactions;
using System.Text.RegularExpressions;
using Entity;
using DAL;

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

        // Validar usuario para el login
        public Usuario ValidarUsuario(string email, string password)
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

        // Obtener usuarios por sector (para cargar los usuarios del sector al que pertenece el administrador)
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

        // Guardar usuario en memoria
        public void GuardarUsuarioEnMemoria(Usuario usuario)
        {
            // Validar los datos del usuario antes de agregarlo
            ValidarDatosUsuario(usuario, esModificacion: false);

            // Verificar duplicados en memoria
            if (_usuariosEnMemoria.Exists(u => u.Email == usuario.Email))
                throw new Exception("El email ya está registrado en memoria.");

            // Validar si el email ya está registrado en la base de datos
            ValidarEmailExistente(usuario.Email);

            _usuariosEnMemoria.Add(usuario);
        }

        // Confirmar usuarios en memoria y guardarlos en la base de datos
        public void ConfirmarUsuarios()
        {
            // Validar duplicados en la lista en memoria
            var emailsDuplicados = _usuariosEnMemoria
                .GroupBy(u => u.Email)
                .Where(grupo => grupo.Count() > 1)
                .Select(grupo => grupo.Key)
                .ToList();

            if (emailsDuplicados.Any())
            {
                throw new Exception($"Error: Los siguientes emails están duplicados en memoria: {string.Join(", ", emailsDuplicados)}.");
            }

            foreach (var usuario in _usuariosEnMemoria)
            {
                try
                {
                    ValidarDatosUsuario(usuario, esModificacion: false);
                    ValidarEmailExistente(usuario.Email);
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

        // Modificar usuario por email
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
                        transaction.Complete();
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

        // Eliminar usuario y sus tareas asociadas
        public void EliminarUsuarioConTareas(string email)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    _usuarioDal.EliminarUsuarioConTareas(email);
                    transaction.Complete();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el usuario y sus tareas en la BLL: " + ex.Message);
                }
            }
        }

        // Validar email existente
        private void ValidarEmailExistente(string email)
        {
            if (_usuarioDal.ExisteEmail(email))
            {
                throw new Exception("El email ya está registrado en la base de datos.");
            }
        }

        // Validar email
        private void ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || email == "EMAIL")
                throw new Exception("El email no puede estar vacío o ser inválido.");

            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, patronEmail))
                throw new Exception("El formato del email no es válido.");
        }

        // Validar campos vacíos
        private void ValidarCampoVacio(string campo, string nombreCampo, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(campo) || campo == placeholder)
                throw new Exception($"El campo {nombreCampo} no puede estar vacío o tener el texto '{placeholder}'.");
        }

        // Validar datos del usuario
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
