using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;


namespace AmigoInvisibleApp
{
    internal class Conexion
    {
        public static string str()
        {
            return  ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        }
    }
}