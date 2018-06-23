using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model.CurrentWeather
{
    public class Sys
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Country { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
        public string SunriseDateTime { get; set; }
        public string SunsetDateTime { get; set; }

        public Sys(int id, int type, string country, int sunrise, int sunset)
        {
            this.Id = id;
            this.Type = type;
            this.Country = country;
            this.Sunrise = sunrise;
            this.Sunset = sunset;
            this.SunriseDateTime = Util.Util.UnixTimeStampToDateTime(sunrise).ToString("t");
            this.SunsetDateTime = Util.Util.UnixTimeStampToDateTime(sunset).ToString("t");
        }

        
    }
}
