using DAL;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

public class TareaDAL
{
    private readonly ConexionDB _conexionDB;

    public TareaDAL()
    {
        _conexionDB = new ConexionDB();
    }

    // Método para obtener las tareas por empleado (para empleado)
    public List<Tarea> ObtenerTareasPorEmpleado(int empleadoId)
    {
        List<Tarea> tareas = new List<Tarea>();

        try
        {
            using (SqlConnection conn = new SqlConnection(_conexionDB.ObtenerCadenaConexion()))
            {
                conn.Open();
                string query = "SELECT TareaId, Titulo, Descripcion, FechaSolicitada, FechaEsperadaFinalizacion, FechaFinalizacion, EstadoTareaId, UsuarioId FROM Tarea WHERE UsuarioId = @empleadoId";

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
        }
        catch (SqlException ex)
        {
            throw new Exception("Error al obtener las tareas del empleado: " + ex.Message);
        }

        return tareas;
    }

    // Método para asignar una nueva tarea a un empleado (para jefe de sector)
    public void AsignarTarea(int usuarioId, string titulo, string descripcion, DateTime fechaEsperadaFinalizacion)
    {
        string query = "INSERT INTO Tarea (Titulo, Descripcion, FechaSolicitada, FechaEsperadaFinalizacion, EstadoTareaId, UsuarioId) " +
                       "VALUES (@Titulo, @Descripcion, GETDATE(), @FechaEsperadaFinalizacion, 1, @UsuarioId)";

        try
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
        }
        catch (SqlException ex)
        {
            throw new Exception("Error al asignar tarea: " + ex.Message);
        }
    }

    // Método para obtener las tareas por sector (para jefe de sector)
    public List<Tarea> ObtenerTareasPorSector(int sectorId)
    {
        List<Tarea> tareas = new List<Tarea>();

        try
        {
            using (SqlConnection conn = new SqlConnection(_conexionDB.ObtenerCadenaConexion()))
            {
                conn.Open();
                string query = "SELECT TareaId, Titulo, Descripcion, FechaSolicitada, FechaEsperadaFinalizacion, FechaFinalizacion, EstadoTareaId, UsuarioId FROM Tarea WHERE UsuarioId IN (SELECT UsuarioId FROM Usuario WHERE SectorId = @SectorId)";

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
        }
        catch (SqlException ex)
        {
            throw new Exception("Error al obtener las tareas del sector: " + ex.Message);
        }

        return tareas;
    }

    // Método para marcar una tarea como completada (para empleado y jefe de sector)
    public void CompletarTarea(int tareaId)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(_conexionDB.ObtenerCadenaConexion()))
            {
                string query = "UPDATE Tarea SET EstadoTareaId = 2, FechaFinalizacion = GETDATE() WHERE TareaId = @TareaId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TareaId", tareaId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("Error al completar la tarea: " + ex.Message);
        }
    }
}
