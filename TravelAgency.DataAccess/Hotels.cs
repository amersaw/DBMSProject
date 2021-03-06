﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Model;

namespace TravelAgency.DataAccess
{
    public class Hotels
    {
        public static List<Hotel> GetCityHotels(int cityId)
        {
            string sql = string.Format("SELECT * FROM Hotels WHERE CityId={0}", cityId);
            return DBRetriever.RetrieveList<Hotel>(sql);
        }

        public static Hotel GetById(int id)
        {
            string sql = string.Format("SELECT * FROM Hotels WHERE Id={0}", id);
            return DBRetriever.Retrieve<Hotel>(sql);
        }
    }
}
