﻿using System.Configuration;


namespace DAL
{
    public class ConexionDB
    {
        public string ObtenerCadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["EmpresaTicketsDB"].ConnectionString;
        }
    }

   

}
