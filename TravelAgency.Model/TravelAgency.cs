using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    public class TravelAgency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HeadquartersAddress { get; set; }
        public string TelNo { get; set; }

        public List<TravelAgencyBranch> Branches { get; set; }

        public TravelAgency(SqlDataReader rdr)
        {
            this.Id = (int)rdr["Id"];
            this.Name = (string)rdr["Name"];
            this.HeadquartersAddress = (string)rdr["HeadquartersAddress"];
            this.TelNo = (string)rdr["TelNo"];
        }
    }

}
