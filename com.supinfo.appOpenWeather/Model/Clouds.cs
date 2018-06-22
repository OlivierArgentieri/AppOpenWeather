using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model
{
    public class Clouds
    {
        public int All { get; set; }

        public Clouds(int all)
        {
            this.All = all;
        }
    }
}
