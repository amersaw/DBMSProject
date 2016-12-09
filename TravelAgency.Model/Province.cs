using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TelCode { get; set; }
        public string Region { get; set; }

        public List<City> Cities { get; set; }

        public Province(SqlDataReader rdr)
        {
            this.Id = (int)rdr["Id"];
            this.Name = (string)rdr["Name"];
            this.TelCode = (string)rdr["TelCode"];
            this.Region = (string)rdr["Region"];
        }
    }
}
