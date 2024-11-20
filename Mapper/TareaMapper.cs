using System;
using System.Data.SqlClient;
using Entity;

namespace Mapper
{
    public static class TareaMapper
    {
        public static Tarea Map(SqlDataReader reader)
        {
            return new Tarea
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
        }
    }
}
