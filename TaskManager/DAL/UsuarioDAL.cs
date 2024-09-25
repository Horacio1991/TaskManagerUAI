using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class UsuarioDAL
    {
        private readonly ConexionDB _conexion;

        public UsuarioDAL()
        {
            _conexion = new ConexionDB(); 
        }

        // Método para obtener todos los usuarios no administradores
        public List<Usuario> ObtenerUsuariosNoAdministradores()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection connection = new SqlConnection(_conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT UsuarioId, Nombre FROM Usuario WHERE EsAdministrador = 0";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario
                        {
                            UsuarioId = (int)reader["UsuarioId"],
                            Nombre = reader["Nombre"].ToString()
                        };
                        usuarios.Add(usuario);
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones si es necesario
                    throw new Exception("Error al obtener usuarios no administradores: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return usuarios;
        }


        // Método para validar credenciales del usuario (email y password)
        public Usuario ValidarUsuario(string email, string password)
        {
            Usuario usuario = null;
            string query = "SELECT UsuarioId, Nombre, EsAdministrador, SectorId FROM Usuario WHERE Email = @Email AND Password = @Password";

            try
            {
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
                                usuario = new Usuario
                                {
                                    UsuarioId = Convert.ToInt32(reader["UsuarioId"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    EsAdministrador = Convert.ToBoolean(reader["EsAdministrador"]),
                                    SectorId = Convert.ToInt32(reader["SectorId"])
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar el usuario.", ex);
            }

            return usuario;
        }

        // Método para obtener usuarios por sector (para jefe de sector)
        public List<Usuario> ObtenerUsuariosPorSector(int sectorId)
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_conexion.ObtenerCadenaConexion()))
                {
                    conn.Open();
                    string query = @"SELECT UsuarioId, Nombre, Email, EsAdministrador, SectorId 
                             FROM Usuario 
                             WHERE SectorId = @SectorId AND EsAdministrador = 0"; // Solo usuarios no administradores

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SectorId", sectorId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario
                                {
                                    UsuarioId = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    EsAdministrador = reader.GetBoolean(3),
                                    SectorId = reader.GetInt32(4)
                                };
                                usuarios.Add(usuario);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener usuarios por sector: " + ex.Message);
            }

            return usuarios;
        }


        // Método para agregar un nuevo usuario 
        public void AgregarUsuario(Usuario usuario)
        {
            string query = "INSERT INTO Usuario (Nombre, Email, Password, EsAdministrador, SectorId) VALUES (@Nombre, @Email, @Password, @EsAdministrador, @SectorId)";

            try
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
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el usuario.", ex);
            }
        }

        // Método para modificar un usuario existente
        public void ModificarUsuarioPorEmail(Usuario usuario)
        {
            // Construimos dinamicamente la query dependiendo de que campos se modifican
            string query = "UPDATE Usuario SET";
            bool actualizarNombre = !string.IsNullOrEmpty(usuario.Nombre);
            bool actualizarPassword = !string.IsNullOrEmpty(usuario.Password);

            if (actualizarNombre)
            {
                query += " Nombre = @Nombre";
            }

            if (actualizarPassword)
            {
                if (actualizarNombre) query += ","; // Si el nombre se actualiza, agregamos una coma
                query += " Password = @Password";
            }

            query += " WHERE Email = @Email";

            try
            {
                using (SqlConnection connection = new SqlConnection(_conexion.ObtenerCadenaConexion()))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    if (actualizarNombre)
                        cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);

                    if (actualizarPassword)
                        cmd.Parameters.AddWithValue("@Password", usuario.Password);

                    cmd.Parameters.AddWithValue("@Email", usuario.Email); // El mail siempre es necesario

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el usuario: " + ex.Message);
            }
        }

        // Metodo para eliminar un usuario y sus tareas asociadas
        public void EliminarUsuarioConTareas(string email)
        {
            string queryEliminarTareas = "DELETE FROM Tarea WHERE UsuarioId = (SELECT UsuarioId FROM Usuario WHERE Email = @Email)";
            string queryEliminarUsuario = "DELETE FROM Usuario WHERE Email = @Email";

            try
            {
                using (SqlConnection connection = new SqlConnection(_conexion.ObtenerCadenaConexion()))
                {
                    connection.Open();

                    // Iniciamos una transacción para asegurar que ambas operaciones se ejecuten correctamente
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Eliminar tareas del usuario
                        using (SqlCommand cmdTareas = new SqlCommand(queryEliminarTareas, connection, transaction))
                        {
                            cmdTareas.Parameters.AddWithValue("@Email", email);
                            cmdTareas.ExecuteNonQuery();
                        }

                        // Eliminar el usuario
                        using (SqlCommand cmdUsuario = new SqlCommand(queryEliminarUsuario, connection, transaction))
                        {
                            cmdUsuario.Parameters.AddWithValue("@Email", email);
                            cmdUsuario.ExecuteNonQuery();
                        }

                        // Si todo va bien, confirmamos la transacción
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Si hay algún error, revertimos los cambios
                        transaction.Rollback();
                        throw new Exception("Error al eliminar el usuario y sus tareas: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión o eliminación: " + ex.Message);
            }
        }

    }
}
