using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model
{
    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }

        public Weather(int id, string main, string description, string icon)
        {
           this.Id = id;
           this.Main = main;
           this.Description = description;
           this.Icon = icon;
        }
    }
}
