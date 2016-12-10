using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    public class Route
    {
        public string Origin { get; set; }
        public int Destination { get; set; }
        public int TravelAgencyId { get; set; }
        public Route(SqlDataReader rdr)
        {
            this.Origin = (string)rdr["Origin"];
            this.Destination = (int)rdr["Destination"];
            this.TravelAgencyId = (int)rdr["TravelAgencyId"];
        }
    }
}
