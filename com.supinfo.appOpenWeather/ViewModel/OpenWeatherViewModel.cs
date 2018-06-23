using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using com.supinfo.appOpenWeather.Annotations;
using Newtonsoft.Json;
using com.supinfo.appOpenWeather.Model.CurrentWeather;
using City = com.supinfo.appOpenWeather.Model.CurrentWeather.City;
using Coord = com.supinfo.appOpenWeather.Model.CurrentWeather.Coord;
using Weather = com.supinfo.appOpenWeather.Model.CurrentWeather.Weather;

namespace com.supinfo.appOpenWeather.ViewModel
{
    public class OpenWeatherViewModel : INotifyPropertyChanged
    {   
        private static OpenWeather _openWeather;
      
        public static OpenWeather OpenWeather
        {
            get
            {
                if (_openWeather == null)
                {
                    _openWeather = new OpenWeather();
                }
                return _openWeather;
            }
            set => _openWeather = value;
        }


        private static string appid = "f020dbbfc3159dabd3999d332a68877f";
        
        public int Id
        {
            get => OpenWeather.Id;
            set => NotifyPropertyChanged(ref OpenWeather.Id, value);
        }

        public string Name
        {
            get => _openWeather.Name;
            set => NotifyPropertyChanged(ref  _openWeather.Name, value);
        }


        public int Cod
        {
            get => _openWeather.Cod;
            set => NotifyPropertyChanged(ref _openWeather.Cod, value);
        }


        public string Base
        {
            get => _openWeather.Base;
            set => NotifyPropertyChanged(ref _openWeather.Base, value);
        }

        public string Visibility
        {
            get => _openWeather.Visibility;
            set => NotifyPropertyChanged(ref _openWeather.Visibility, value);
        }

        public string Dt
        {
            get => _openWeather.Dt;
            set => NotifyPropertyChanged(ref _openWeather.Dt, value);
        }


        public Coord Coord
        {
            get => _openWeather.Coord;
            set => NotifyPropertyChanged(ref _openWeather.Coord, value);
        }


        public List<Weather> Weather
        {
            get => _openWeather.Weather;
            set => NotifyPropertyChanged(ref _openWeather.Weather, value);
        }


        public Main Main
        {
            get => _openWeather.Main;
            set => NotifyPropertyChanged(ref _openWeather.Main, value);
        }


        public Wind Wind
        {
            get => _openWeather.Wind;
            set => NotifyPropertyChanged(ref _openWeather.Wind, value);
        }


        public Clouds Clouds
        {
            get => _openWeather.Clouds;
            set => NotifyPropertyChanged(ref _openWeather.Clouds, value);
        }

        public City City
        {
            get => _openWeather.City;
            set => NotifyPropertyChanged(ref _openWeather.City, value);
        }

        public Sys Sys
        {
            get => _openWeather.Sys;
            set => NotifyPropertyChanged(ref _openWeather.Sys, value);
        }

        public Dictionary<string, string> Countries
        {
            get => _openWeather.Countries;
            set => NotifyPropertyChanged(ref _openWeather.Countries, value);
        }

        public ForecastViewModel ForecastViewModel { get; set; }


        public OpenWeatherViewModel()
        {
            OpenWeatherViewModel._openWeather = new OpenWeather();
        }

        
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

        public static Task<OpenWeatherViewModel> GetWeatherAsync(string country, string postalCode) => Task.Run(async () =>
        {
            // Loading CurrentWeather
            var url = String.Format("http://api.openweathermap.org/data/2.5/weather?zip={0},{1}&appid={2}&units=metric", postalCode, country, appid);
            HttpClient client = new HttpClient();

            postalCode = await client.GetStringAsync(url);

            var json = JsonConvert.DeserializeObject<OpenWeatherViewModel>(postalCode);
            return json;
        });

        

        public static Task<Dictionary<string, string>> GetCountriesAsync() => Task.Run(async () =>
        {
            var url = String.Format("http://country.io/names.json");
            HttpClient client = new HttpClient();

            var city = await client.GetStringAsync(url);

            var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(city);

            return values;
        });
    }
}
