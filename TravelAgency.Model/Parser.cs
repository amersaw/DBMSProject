using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    public static class Parser
    {
        public static object Parse<T>(SqlDataReader rdr)
        {
            if (typeof(T) == typeof(City))
                return new City(rdr);

            if (typeof(T) == typeof(Province))
                return new Province(rdr);

            if (typeof(T) == typeof(Hotel))
                return new Hotel(rdr);

            if (typeof(T) == typeof(PublicTransportation))
                return new PublicTransportation(rdr);

            if (typeof(T) == typeof(TouristicSite))
                return new TouristicSite(rdr);

            if (typeof(T) == typeof(Restaurant))
                return new Restaurant(rdr);

            if (typeof(T) == typeof(TravelAgency))
                return new TravelAgency(rdr);

            if (typeof(T) == typeof(TravelAgencyBranch))
                return new TravelAgencyBranch(rdr);

            if (typeof(T) == typeof(Route))
                return new Route(rdr);

            if (typeof(T) == typeof(int))
                return (T)rdr[0];

            return null;
        }
    }
}
