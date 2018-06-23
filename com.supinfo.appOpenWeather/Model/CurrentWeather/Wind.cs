using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model.CurrentWeather
{
    public class Wind
    {
        public float Speed { get; set; }
        public float Deg { get; set; }
        public float Gust { get; set; }

        public Wind(float speed, float deg, float gust)
        {
            this.Speed = speed;
            this.Deg = deg;
            this.Gust = gust;
        }
    }
}
