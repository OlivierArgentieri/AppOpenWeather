using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model.CurrentWeather
{
    public class Coord
    {
        public decimal Lon { get; set; }
        public decimal Lat { get; set; }

        public Coord(decimal lon, decimal lat)
        {
            this.Lon = lon;
            this.Lat = lat;
        }
    }
}
