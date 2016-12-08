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

        private static SqlConnection _con = null;

        public static SqlConnection GetConnection()
        {
            if (_con == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                _con = new SqlConnection(connectionString);
            }
            return _con;
        }
    }
}
