using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Model;

namespace TravelAgency.DataAccess
{
    public static class Provinces
    {
        public static List<Province> GetAll()
        {
            List<Province> retVal = new List<Province>();
            var con = ConnectionManager.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Province",con);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                retVal.Add(new Province(rdr));
            }
            return retVal;
        }
    }
}
