using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelAgency.Model;

namespace TravelAgency
{
    public static class Globals
    {
        private static List<Province> _allProvinces;
        public static List<Province> AllProvinces
        {
            get
            {
                if(_allProvinces == null)
                {
                    _allProvinces = DataAccess.Provinces.GetAll();
                    for (int i = 0; i < _allProvinces.Count; i++)
                        _allProvinces[i].Cities = DataAccess.Cities.GetProvinceCities(_allProvinces[i].Id);
                }
                return _allProvinces;
            }
        }

    }
}