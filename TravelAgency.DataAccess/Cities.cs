using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Model;

namespace TravelAgency.DataAccess
{
    public class Cities
    {
        public static List<City> GetProvinceCities(int provinceId)
        {
            List<City> retVal = new List<City>();
            using (SqlConnection con = ConnectionManager.GetConnection())
            {
                string sql = string.Format("SELECT * FROM City WHERE ProvinceId={0}", provinceId);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                            retVal.Add(new City(rdr));
                    }
                }
                return retVal;
            }
        }
    }
}
