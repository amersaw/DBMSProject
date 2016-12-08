﻿using System;
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
            using (SqlConnection con = ConnectionManager.GetConnection())
            {
                string sql = "SELECT * FROM Province";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                            retVal.Add(new Province(rdr));
                    }
                    return retVal;
                }
            }
        }
    }
}
