using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    public static class Parser
    {
        public static object Parse<T>(SqlDataReader rdr)
        {
            if (typeof(T) == typeof(City))
                return new City(rdr);
            if (typeof(T) == typeof(Province))
                return new Province(rdr);

            return null;
        }
    }
}
