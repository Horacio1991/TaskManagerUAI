using System.Configuration;


namespace DAL
{
    public class ConexionDB
    {
        // Método para obtener la cadena de conexión desde el app.config
        public string ObtenerCadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["EmpresaTicketsDB"].ConnectionString;
        }
    }

   

}
