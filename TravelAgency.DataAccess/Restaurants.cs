using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Model;

namespace TravelAgency.DataAccess
{
    public class Restaurants
    {
        public static List<Restaurant> GetCityRestaurants(int cityId)
        {
            string sql = string.Format("SELECT * FROM Restaurants WHERE CityId={0}", cityId);
            return DBRetriever.RetrieveList<Restaurant>(sql);
        }

        public static Restaurant GetById(int id)
        {
            string sql = string.Format("SELECT * FROM Restaurants WHERE Id={0}", id);
            return DBRetriever.Retrieve<Restaurant>(sql);
        }
    }
}
