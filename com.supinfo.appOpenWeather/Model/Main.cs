using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model
{
    public class Main
    {
        public float Temp { get; set; }
        public float Pressure { get; set; }
        public float Humidity { get; set; }
        public float Temp_Min { get; set; }
        public float Temp_Max { get; set; }

        public Main(float temp, float pressure, float humidity, float temp_Min, float temp_Max)
        {
            this.Temp = temp;
            this.Pressure = pressure;
            this.Humidity = humidity;
            this.Temp_Min = temp_Min;
            this.Temp_Max = temp_Max;
        }
    }
}
