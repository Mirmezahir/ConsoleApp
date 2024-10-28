using Core.Helpers.Region;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Country
    {
        public Region region;
        public string Region;
        private static int _id;
        public Country(string countryName, double area, string anthem)
        {
            ++_id;
            CountryID = _id;
            CountryName = countryName;
            Area = area;
            Anthem = anthem;
           
        }

        public Country(string countryName, double area, string anthem,Region region)
        {
            ++_id;
            CountryID = _id;
            CountryName = countryName;
            Area = area;
            Anthem = anthem;
            Region= region.ToString();
        }

        public  int CountryID  { get; set; }
        public  string CountryName { get; set; }
        public double Area { get; set; }
        public string Anthem { get; set; }



    }
}
