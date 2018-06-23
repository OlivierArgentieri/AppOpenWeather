using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model.Forecasts
{
    public class Forecasts
    {

        #region Attribut

        private string _cod;
        private string _message;
        private List<Data> _list;
#endregion

        public ref string Cod => ref _cod;
        public ref string Message => ref _message;
        public ref List<Data> List => ref _list;

        public Forecasts()
        {

        }

        public Forecasts(string cod, string message, List<Data> list)
        {
            Cod = cod;
            Message = message;
            List = list;
        }
    }
}
