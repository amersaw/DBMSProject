using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.DataAccess
{
    public class ConnectionManager
    {

        private static string _connectionString;
        static ConnectionManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        public static SqlConnection GetConnection()
        {
            var _con = new SqlConnection(_connectionString);
            _con.Open();
            return _con;

        }
    }
}
