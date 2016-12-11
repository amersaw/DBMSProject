using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Model;

namespace TravelAgency.DataAccess
{
    public class TouristicSites
    {
        public static List<TouristicSite> GetCityTouristicSites(int cityId)
        {
            string sql = string.Format("SELECT * FROM TouristicSites WHERE CityId={0}", cityId);
            return DBRetriever.RetrieveList<TouristicSite>(sql);
        }

        public static TouristicSite GetById(int id)
        {
            string sql = string.Format("SELECT * FROM TouristicSites WHERE Id={0}", id);
            return DBRetriever.Retrieve<TouristicSite>(sql);
        }
    }
}
