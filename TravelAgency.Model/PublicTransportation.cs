using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    public class PublicTransportation
    {
        public int Id { get; set; }
        public PublicTransportationType Type { get; set; }
        public string OpeningHours { get; set; }
        public int CityId { get; set; }

        public PublicTransportation(SqlDataReader rdr)
        {
            this.Id = (int)rdr["Id"];
            this.Type = (PublicTransportationType)rdr["Type"];
            this.OpeningHours = (string)rdr["OpeningHours"];
            this.CityId = (int)rdr["CityId"];
        }
    }
}
