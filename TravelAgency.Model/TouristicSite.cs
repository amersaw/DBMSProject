using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    public class TouristicSite
    {
        public int Id { get; set; }
        public string OpeningHours { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public TouristicSite(SqlDataReader rdr)
        {
            this.Id = (int)rdr["Id"];
            this.OpeningHours = (string)rdr["OpeningHours"];
            this.Type = (string)rdr["Type"];
            this.Address = (string)rdr["Address"];
            this.CityId = (int)rdr["CityId"];
        }
    }
}
