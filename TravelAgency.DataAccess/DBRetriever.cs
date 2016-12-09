using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.DataAccess
{
    public class DBRetriever
    {
        public static List<T> RetrieveList<T>(string sql)
        {
            List<T> retVal = new List<T>();
            using (SqlConnection con = ConnectionManager.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            using (SqlDataReader rdr = cmd.ExecuteReader())
                while (rdr.Read())
                    retVal.Add((T)Model.Parser.Parse<T>(rdr));
            return retVal;
        }
        public static T Retrieve<T>(string sql)
        {
            using (SqlConnection con = ConnectionManager.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            using (SqlDataReader rdr = cmd.ExecuteReader())
                if (rdr.Read())
                    return ((T)Model.Parser.Parse<T>(rdr));
                else
                    return default(T);
        }
    }
}
