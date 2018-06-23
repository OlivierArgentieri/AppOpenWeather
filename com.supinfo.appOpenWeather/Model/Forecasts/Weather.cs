using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model.Forecasts
{
    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string IconUrl { get; set; }
          

        public Weather(int id, string main, string description, string icon)
        {
            Id = id;
            Main = main;
            Description = description;
            Icon = icon;
            IconUrl = String.Format("http://openweathermap.org/img/w/{0}.png", icon);
        }
    }
}
