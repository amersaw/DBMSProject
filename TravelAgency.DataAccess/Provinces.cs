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
            string sql = "SELECT * FROM Province";
            return DBRetriever.RetrieveList<Province>(sql);
        }
    }
}
