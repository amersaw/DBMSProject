using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string ServiceQuality { get; set; }
        public string Tel { get; set; }
        public int CityId { get; set; }

        public string CityName { get; set; }
        public string ProvinceName { get; set; }

        public Hotel(SqlDataReader rdr)
        {
            this.Id = (int)rdr["Id"];
            this.Name = (string)rdr["Name"];
            this.Latitude = (string)rdr["Latitude"];
            this.Longitude = (string)rdr["Longitude"];
            this.ServiceQuality = (string)rdr["ServiceQuality"];
            this.Tel = (string)rdr["Tel"];
            this.CityId = (int)rdr["CityId"];
        }
    }

}
