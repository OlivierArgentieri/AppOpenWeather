using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model.Forecasts
{
    public class Data
    {
        public int Dt { get; set; }
        public Main Main { get; set; }
        public List<Weather> Weather { get; set; }
        public Clouds Clouds { get; set; }
        public Wind Wind { get; set; }
        public Sys Sys { get; set; }
        public string Dt_txt { get; set; }

        public Data(int dt, Main main, List<Weather> weather, Clouds clouds, Wind wind, Sys sys, string dt_txt)
        {
            this.Dt = dt;
            this.Main = main;
            this.Weather = weather;
            this.Clouds = clouds;
            this.Wind = wind;
            this.Sys = sys;
            this.Dt_txt = dt_txt;
        }

        public Data()
        {

        }
        



    }
}
