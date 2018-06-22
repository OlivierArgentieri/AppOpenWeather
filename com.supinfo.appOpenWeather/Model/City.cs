using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.supinfo.appOpenWeather.Model
{
    class City
    {
        // http://country.io/names.json
        private string _base;
        private string _visibility;

        public ref string Base => ref _base;
        public ref string Visibility => ref _visibility;
    }
}
