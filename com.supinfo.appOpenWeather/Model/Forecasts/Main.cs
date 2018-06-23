using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model.Forecasts
{
    public class Main
    {
        public float Temp { get; set; }
        public float Pressure { get; set; }
        public float Humidity { get; set; }
        public float Temp_Min { get; set; }
        public float Temp_Max { get; set; }
        public float sea_level { get; set; }
        public float grnd_level { get; set; }
        public float temp_kf { get; set; }

        public Main(float temp, float pressure, float humidity, float temp_Min, float temp_Max, float sea_level, float grnd_level, float temp_kf)
        {
            Temp = temp;
            Pressure = pressure;
            Humidity = humidity;
            Temp_Min = temp_Min;
            Temp_Max = temp_Max;
            this.sea_level = sea_level;
            this.grnd_level = grnd_level;
            this.temp_kf = temp_kf;
        }

        public Main()
        {
        }
    }
}
