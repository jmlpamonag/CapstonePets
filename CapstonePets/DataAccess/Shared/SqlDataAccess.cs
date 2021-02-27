using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace CapstonePets.DataAccess.Shared
{
    public class SqlDataAccess
    {
        //TO DO: Add Database Name
        public static string GetConnectionString(string ConnectionName = "TO DO: Add Database Name Here")
        {
            return ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (SqlConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }
    }
}