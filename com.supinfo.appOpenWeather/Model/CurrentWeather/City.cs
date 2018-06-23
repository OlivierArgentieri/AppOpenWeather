using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model.CurrentWeather
{

    public class City
    {
        public string Country { get; set; }
        public string Name { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }

        public City(string country, string name, string lat, string lng)
        {
            this.Country = country;
            this.Name = name;
            this.Lat = lat;
            this.Lng = lng;
        }
    }

}
