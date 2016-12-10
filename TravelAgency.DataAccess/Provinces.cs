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

        public static Province GetById(int id)
        {
            string sql = string.Format("SELECT * FROM Province WHERE Id={0}", id);
            return DBRetriever.Retrieve<Province>(sql);
        }

        public static int GetTotalPopulation(int id)
        {
            string sql = string.Format("SELECT SUM(Population) FROM City WHERE ProvinceId={0}", id);
            return DBRetriever.Retrieve<int>(sql);
        }
    }
}
