using System.Data.SqlClient;
using Entity;

namespace Mapper
{
    public static class UsuarioMapper
    {
        public static Usuario Map(SqlDataReader reader)
        {
            return new Usuario
            {
                UsuarioId = reader.GetInt32(reader.GetOrdinal("UsuarioId")),
                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                Email = reader.GetString(reader.GetOrdinal("Email")),
                Password = reader.IsDBNull(reader.GetOrdinal("Password")) ? null : reader.GetString(reader.GetOrdinal("Password")),
                EsAdministrador = reader.GetBoolean(reader.GetOrdinal("EsAdministrador")),
                SectorId = reader.GetInt32(reader.GetOrdinal("SectorId"))
            };
        }
    }
}
