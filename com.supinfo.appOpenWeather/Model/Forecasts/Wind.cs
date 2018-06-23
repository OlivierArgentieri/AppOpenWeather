using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model.Forecasts
{
    public class Wind
    {
        public float Speed { get; set; }
        public float Deg { get; set; }

        public Wind(float speed, float deg)
        {
            Speed = speed;
            Deg = deg;
        }

        public Wind()
        {
        }
    }
}
