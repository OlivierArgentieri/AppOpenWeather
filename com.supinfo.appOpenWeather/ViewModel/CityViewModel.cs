using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using com.supinfo.appOpenWeather.Model;
using Newtonsoft.Json;

namespace com.supinfo.appOpenWeather.ViewModel
{
    public class CityViewModel :INotifyPropertyChanged
    {

        private static City _city;

        /*public static City City
        {
            get
            {
                if (_city == null)
                {
                    _city = new City();
                    
                }
                return _city;
            }
            set => _city = value;
        }
        
    */

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void NotifyPropertyChanged(string nomPropriete)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomPropriete));
        }

        private void NotifyPropertyChanged<T>(ref T variable, T valeur, [CallerMemberName] string nomPropriete = null)
        {
            if (Equals(variable, valeur)) return;

            variable = valeur;
            NotifyPropertyChanged(nomPropriete);
        }

       
    }
}
