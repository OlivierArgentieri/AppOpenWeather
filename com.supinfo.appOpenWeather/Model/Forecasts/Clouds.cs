using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model.Forecasts
{
    public class Clouds
    {
        public float All { get; set; }

        public Clouds(int all)
        {
            this.All = all;
        }
    }
}
