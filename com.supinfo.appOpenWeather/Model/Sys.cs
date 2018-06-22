using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model
{
    public class Sys
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Country { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }

        public Sys(int id, int type, string country, int sunrise, int sunset)
        {
            this.Id = id;
            this.Type = type;
            this.Country = country;
            this.Sunrise = sunrise;
            this.Sunset = sunset;
        }
    }
}
