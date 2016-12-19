using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelAgency.Model;

namespace TravelAgency
{
    public static class Globals
    {
        public static string CleanString (string s)
        {
            return string.Join("", s.Where(c => c == '.' || char.IsDigit(c) || c == '-').ToArray());
        }
        private static List<Province> _allProvinces;
        private static DateTime _allProvincesUpdate;
        public static List<Province> AllProvinces
        {
            get
            {
                if (_allProvinces == null || (DateTime.Now - _allProvincesUpdate).TotalSeconds>20)
                {
                    _allProvincesUpdate = DateTime.Now;
                    _allProvinces = DataAccess.Provinces.GetAll();
                    for (int i = 0; i < _allProvinces.Count; i++)
                        _allProvinces[i].Cities = DataAccess.Cities.GetProvinceCities(_allProvinces[i].Id);
                }
                return _allProvinces;
            }
            set { _allProvinces = value; }
        }

    }
}