using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Model;

namespace TravelAgency.DataAccess
{
    public class TravelAgencyBranches
    {
        public static List<TravelAgencyBranch> GetAgencyBranches(int id)
        {
            string sql = string.Format("SELECT * FROM TravelAgencyBranch WHERE TravelAgencyId={0}", id);
            return DBRetriever.RetrieveList<TravelAgencyBranch>(sql);
        }

        public static TravelAgencyBranch GetById(int id)
        {
            string sql = string.Format("SELECT * FROM TravelAgencyBranch WHERE Id={0}", id);
            return DBRetriever.Retrieve<TravelAgencyBranch>(sql);
        }

        public static List<TravelAgencyBranch> GetCityBranches(int id)
        {
            string sql = string.Format("SELECT * FROM TravelAgencyBranch WHERE CityId={0}", id);
            return DBRetriever.RetrieveList<TravelAgencyBranch>(sql);
        }
    }
}
