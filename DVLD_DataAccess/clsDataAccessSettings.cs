using System;
using System.Configuration;

namespace DVLD_DataAccess
{
    public static class clsDataAccessSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
    }
}
