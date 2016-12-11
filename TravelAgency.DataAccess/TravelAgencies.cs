using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Model;

namespace TravelAgency.DataAccess
{
    public class TravelAgencies
    {
        public static List<Model.TravelAgency> GetAll()
        {
            string sql = string.Format("SELECT * FROM TravelAgency");
            return DBRetriever.RetrieveList<Model.TravelAgency>(sql);
        }

        public static Model.TravelAgency GetById(int id)
        {
            string sql = string.Format("SELECT * FROM TravelAgency WHERE Id={0}", id);
            return DBRetriever.Retrieve<Model.TravelAgency>(sql);
        }
    }
}
