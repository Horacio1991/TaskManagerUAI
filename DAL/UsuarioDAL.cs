using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Transactions;
using Entity;
using Mapper;

namespace DAL
{
    public class UsuarioDAL
    {
        private readonly ConexionDB _conexion;

        public UsuarioDAL()
        {
            _conexion = new ConexionDB();
        }

        // Validar usuario para el login
        public Usuario ValidarUsuario(string email, string password)
        {
            Usuario usuario = null;
            string query = "SELECT UsuarioId, Nombre, Email, Password, EsAdministrador, SectorId FROM Usuario WHERE Email = @Email AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(_conexion.ObtenerCadenaConexion()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = UsuarioMapper.Map(reader); 
                        }
                    }
                }
            }

            return usuario;
        }

        // Obtener usuarios por sector (Para cargar empleados en el ComboBox de las tareas a asignar)
        public List<Usuario> ObtenerUsuariosPorSector(int sectorId)
        {
            List<Usuario> usuarios = new List<Usuario>();
            string query = @"SELECT UsuarioId, Nombre, Email, Password, EsAdministrador, SectorId 
                             FROM Usuario 
                             WHERE SectorId = @SectorId AND EsAdministrador = 0";

            using (SqlConnection conn = new SqlConnection(_conexion.ObtenerCadenaConexion()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SectorId", sectorId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuarios.Add(UsuarioMapper.Map(reader));
                        }
                    }
                }
            }

            return usuarios;
        }

        // Agregar un nuevo usuario
        public void AgregarUsuario(Usuario usuario)
        {
            string query = "INSERT INTO Usuario (Nombre, Email, Password, EsAdministrador, SectorId) " +
                           "VALUES (@Nombre, @Email, @Password, @EsAdministrador, @SectorId)";

            using (TransactionScope transaction = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(_conexion.ObtenerCadenaConexion()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        cmd.Parameters.AddWithValue("@Email", usuario.Email);
                        cmd.Parameters.AddWithValue("@Password", usuario.Password);
                        cmd.Parameters.AddWithValue("@EsAdministrador", usuario.EsAdministrador);
                        cmd.Parameters.AddWithValue("@SectorId", usuario.SectorId);

                        cmd.ExecuteNonQuery();
                    }
                }
                transaction.Complete();
            }
        }

        // Modificar usuario por email
        public void ModificarUsuarioPorEmail(Usuario usuario)
        {
            string query = "UPDATE Usuario SET";

            bool actualizarNombre = !string.IsNullOrEmpty(usuario.Nombre);
            bool actualizarPassword = !string.IsNullOrEmpty(usuario.Password);

            if (actualizarNombre)
            {
                query += " Nombre = @Nombre";
            }

            if (actualizarPassword)
            {
                if (actualizarNombre) query += ",";
                query += " Password = @Password";
            }

            query += " WHERE Email = @Email";

            using (TransactionScope transaction = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(_conexion.ObtenerCadenaConexion()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (actualizarNombre)
                            cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);

                        if (actualizarPassword)
                            cmd.Parameters.AddWithValue("@Password", usuario.Password);

                        cmd.Parameters.AddWithValue("@Email", usuario.Email);

                        cmd.ExecuteNonQuery();
                    }
                }
                transaction.Complete();
            }
        }

        // Eliminar usuario y sus tareas asociadas
        public void EliminarUsuarioConTareas(string email)
        {
            string queryEliminarTareas = "DELETE FROM Tarea WHERE UsuarioId = (SELECT UsuarioId FROM Usuario WHERE Email = @Email)";
            string queryEliminarUsuario = "DELETE FROM Usuario WHERE Email = @Email";

            using (TransactionScope transaction = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(_conexion.ObtenerCadenaConexion()))
                {
                    connection.Open();

                    using (SqlCommand cmdTareas = new SqlCommand(queryEliminarTareas, connection))
                    {
                        cmdTareas.Parameters.AddWithValue("@Email", email);
                        cmdTareas.ExecuteNonQuery();
                    }

                    using (SqlCommand cmdUsuario = new SqlCommand(queryEliminarUsuario, connection))
                    {
                        cmdUsuario.Parameters.AddWithValue("@Email", email);
                        cmdUsuario.ExecuteNonQuery();
                    }
                }
                transaction.Complete();
            }
        }

        public bool ExisteEmail(string email)
        {
            string query = "SELECT COUNT(*) FROM Usuario WHERE Email = @Email";

            using (SqlConnection conn = new SqlConnection(_conexion.ObtenerCadenaConexion()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

    }
}
