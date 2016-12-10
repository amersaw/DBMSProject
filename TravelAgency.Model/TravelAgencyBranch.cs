using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    public class TravelAgencyBranch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TelNo { get; set; }
        public int CityId { get; set; }
        public int TravelAgencyId { get; set; }
        public TravelAgencyBranch(SqlDataReader rdr)
        {
            this.Id = (int)rdr["Id"];
            this.Name = (string)rdr["Name"];
            this.Address = (string)rdr["Address"];
            this.TelNo = (string)rdr["TelNo"];
            this.CityId = (int)rdr["CityId"];
            this.TravelAgencyId = (int)rdr["TravelAgencyId"];
        }

    }
}
