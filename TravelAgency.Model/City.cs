using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longtude { get; set; }
        public int Population { get; set; }
        public int ProvinceId { get; set; }


        public List<Restaurant> Restaurants { get; set; }
        public List<Hotel> Hotels { get; set; }
        public List<TouristicSite> TouristicSites { get; set; }
        public List<TravelAgencyBranch> TravelAgencyBranches { get; set; }

        public City(SqlDataReader rdr)
        {
            this.Id = (int)rdr["Id"];
            this.Name = (string)rdr["Name"];
            this.Latitude = (string)rdr["Latitude"];
            this.Longtude = (string)rdr["Longtude"];
            this.Population = (int)rdr["Population"];
            this.ProvinceId = (int)rdr["ProvinceId"];
        }
    }
}
