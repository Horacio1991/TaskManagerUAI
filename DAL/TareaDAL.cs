using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Transactions;
using Entity;
using Mapper;

namespace DAL
{
    public class TareaDAL
    {
        private readonly ConexionDB _conexionDB;

        public TareaDAL()
        {
            _conexionDB = new ConexionDB();
        }

        // Obtener tareas por empleado
        public List<Tarea> ObtenerTareasPorEmpleado(int empleadoId)
        {
            List<Tarea> tareas = new List<Tarea>();
            string query = @"SELECT TareaId, Titulo, Descripcion, FechaSolicitada, 
                                    FechaEsperadaFinalizacion, FechaFinalizacion, 
                                    EstadoTareaId, UsuarioId 
                             FROM Tarea 
                             WHERE UsuarioId = @empleadoId";

            using (SqlConnection conn = new SqlConnection(_conexionDB.ObtenerCadenaConexion()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@empleadoId", empleadoId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tareas.Add(TareaMapper.Map(reader)); 
                        }
                    }
                }
            }
            return tareas;
        }

        // Asignar una nueva tarea
        public void AsignarTarea(int usuarioId, string titulo, string descripcion, DateTime fechaEsperadaFinalizacion)
        {
            string query = @"INSERT INTO Tarea (Titulo, Descripcion, FechaSolicitada, 
                                                 FechaEsperadaFinalizacion, EstadoTareaId, UsuarioId) 
                             VALUES (@Titulo, @Descripcion, GETDATE(), 
                                     @FechaEsperadaFinalizacion, 1, @UsuarioId)";

            using (TransactionScope transaction = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(_conexionDB.ObtenerCadenaConexion()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Titulo", titulo);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@FechaEsperadaFinalizacion", fechaEsperadaFinalizacion);
                        cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                transaction.Complete();
            }
        }

        // Obtener tareas por sector
        public List<Tarea> ObtenerTareasPorSector(int sectorId)
        {
            List<Tarea> tareas = new List<Tarea>();
            string query = @"SELECT TareaId, Titulo, Descripcion, FechaSolicitada, 
                                    FechaEsperadaFinalizacion, FechaFinalizacion, 
                                    EstadoTareaId, UsuarioId 
                             FROM Tarea 
                             WHERE UsuarioId IN (SELECT UsuarioId FROM Usuario WHERE SectorId = @SectorId)";

            using (SqlConnection conn = new SqlConnection(_conexionDB.ObtenerCadenaConexion()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SectorId", sectorId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tareas.Add(TareaMapper.Map(reader)); 
                        }
                    }
                }
            }
            return tareas;
        }

        // Completar una tarea
        public void CompletarTarea(int tareaId)
        {
            string query = "UPDATE Tarea SET EstadoTareaId = 2, FechaFinalizacion = GETDATE() WHERE TareaId = @TareaId";

            using (TransactionScope transaction = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(_conexionDB.ObtenerCadenaConexion()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TareaId", tareaId);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                transaction.Complete();
            }
        }
    }
}
