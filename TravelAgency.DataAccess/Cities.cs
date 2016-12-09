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
            string sql = string.Format("SELECT * FROM City WHERE ProvinceId={0}", provinceId);
            return DBRetriever.RetrieveList<City>(sql);
        }

        public static City GetCity(int id)
        {
            string sql = string.Format("SELECT * FROM City WHERE Id={0}", id);
            return DBRetriever.Retrieve<City>(sql);
        }
    }
}
