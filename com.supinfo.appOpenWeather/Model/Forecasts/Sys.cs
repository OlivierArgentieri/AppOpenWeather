using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model.Forecasts
{
    public class Sys
    {
        public string Prod { get; set; }

        public Sys(string prod)
        {
            Prod = prod;
        }

        public Sys()
        {
        }
    }
}
