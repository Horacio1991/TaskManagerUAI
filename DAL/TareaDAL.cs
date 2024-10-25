using System.Data.SqlClient;
using System.Transactions;
using Entity;

namespace DAL
{
    public class TareaDAL
    {
        private readonly ConexionDB _conexionDB;

        public TareaDAL()
        {
            _conexionDB = new ConexionDB();
        }

        public List<Tarea> ObtenerTareasPorEmpleado(int empleadoId) //Para cargar las tareas en el DataGridView del empleado seleccionado
        {
            List<Tarea> tareas = new List<Tarea>();

            using (SqlConnection conn = new SqlConnection(_conexionDB.ObtenerCadenaConexion()))
            {
                conn.Open();
                string query = "SELECT TareaId, Titulo, Descripcion, FechaSolicitada, " +
                               "FechaEsperadaFinalizacion, FechaFinalizacion, EstadoTareaId, UsuarioId " +
                               "FROM Tarea WHERE UsuarioId = @empleadoId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@empleadoId", empleadoId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tarea tarea = new Tarea
                            {
                                TareaId = reader.GetInt32(reader.GetOrdinal("TareaId")),
                                Titulo = reader.GetString(reader.GetOrdinal("Titulo")),
                                Descripcion = reader.GetString(reader.GetOrdinal("Descripcion")),
                                FechaSolicitada = reader.GetDateTime(reader.GetOrdinal("FechaSolicitada")),
                                FechaEsperadaFinalizacion = reader.GetDateTime(reader.GetOrdinal("FechaEsperadaFinalizacion")),
                                FechaFinalizacion = reader.IsDBNull(reader.GetOrdinal("FechaFinalizacion")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("FechaFinalizacion")),
                                EstadoTareaId = reader.GetInt32(reader.GetOrdinal("EstadoTareaId")),
                                UsuarioId = reader.GetInt32(reader.GetOrdinal("UsuarioId"))
                            };
                            tareas.Add(tarea);
                        }
                    }
                }
            }
            return tareas;
        }

        public void AsignarTarea(int usuarioId, string titulo, string descripcion, DateTime fechaEsperadaFinalizacion)
        {
            string query = "INSERT INTO Tarea (Titulo, Descripcion, FechaSolicitada, FechaEsperadaFinalizacion, EstadoTareaId, UsuarioId) " +
                           "VALUES (@Titulo, @Descripcion, GETDATE(), @FechaEsperadaFinalizacion, 1, @UsuarioId)";

            using (TransactionScope transaction = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(_conexionDB.ObtenerCadenaConexion()))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Titulo", titulo);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@FechaEsperadaFinalizacion", fechaEsperadaFinalizacion);
                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                transaction.Complete();
            }
        }

        public List<Tarea> ObtenerTareasPorSector(int sectorId)
        {
            List<Tarea> tareas = new List<Tarea>();

            using (SqlConnection conn = new SqlConnection(_conexionDB.ObtenerCadenaConexion()))
            {
                conn.Open();
                string query = "SELECT TareaId, Titulo, Descripcion, FechaSolicitada, " +
                               "FechaEsperadaFinalizacion, FechaFinalizacion, EstadoTareaId, UsuarioId " +
                               "FROM Tarea WHERE UsuarioId IN (SELECT UsuarioId FROM Usuario WHERE SectorId = @SectorId)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SectorId", sectorId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tarea tarea = new Tarea
                            {
                                TareaId = reader.GetInt32(reader.GetOrdinal("TareaId")),
                                Titulo = reader.GetString(reader.GetOrdinal("Titulo")),
                                Descripcion = reader.GetString(reader.GetOrdinal("Descripcion")),
                                FechaSolicitada = reader.GetDateTime(reader.GetOrdinal("FechaSolicitada")),
                                FechaEsperadaFinalizacion = reader.GetDateTime(reader.GetOrdinal("FechaEsperadaFinalizacion")),
                                FechaFinalizacion = reader.IsDBNull(reader.GetOrdinal("FechaFinalizacion")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("FechaFinalizacion")),
                                EstadoTareaId = reader.GetInt32(reader.GetOrdinal("EstadoTareaId")),
                                UsuarioId = reader.GetInt32(reader.GetOrdinal("UsuarioId"))
                            };
                            tareas.Add(tarea);
                        }
                    }
                }
            }
            return tareas;
        }

        public void CompletarTarea(int tareaId)
        {
            string query = "UPDATE Tarea SET EstadoTareaId = 2, FechaFinalizacion = GETDATE() WHERE TareaId = @TareaId";

            using (TransactionScope transaction = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(_conexionDB.ObtenerCadenaConexion()))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TareaId", tareaId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                transaction.Complete();
            }
        }
    }
}
