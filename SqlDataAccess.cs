using System;
using System.Configuration;

namespace FreeBook
{
    class SqlDataAccess
    {
        public static string GetConnectionStrings()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public static string GetCartiPathStrings()
        {
            return ConfigurationManager.AppSettings["Carti"];
        }
    }
}
