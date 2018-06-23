using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using com.supinfo.appOpenWeather.Model.Forecasts;
using Newtonsoft.Json;

namespace com.supinfo.appOpenWeather.ViewModel
{
    public class ForecastViewModel : INotifyPropertyChanged
    {
        private static string appid = "f020dbbfc3159dabd3999d332a68877f";
        private static Forecasts _forecasts;

        public static Forecasts Forecasts
        {
            get
            {
                if (_forecasts == null)
                {
                    _forecasts = new Forecasts();
                }
                return _forecasts;
            }
            set => _forecasts = value;
        }

        public string Cod
        {
            get => Forecasts.Cod;
            set => NotifyPropertyChanged(ref Forecasts.Cod, value);
        }

        public string Message
        {
            get => Forecasts.Message;
            set => NotifyPropertyChanged(ref Forecasts.Message, value);
        }

        public List<Data> List
        {
            get => Forecasts.List;
            set => NotifyPropertyChanged(ref Forecasts.List, value);
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
        public static Task<ForecastViewModel> GetForecastAsync(string country, string postalCode) => Task.Run(async () =>
        {
            var url = String.Format("http://api.openweathermap.org/data/2.5/forecast?zip={0},{1}&appid={2}&units=metric", postalCode, country, appid);
            HttpClient client = new HttpClient();

            postalCode = await client.GetStringAsync(url);

            var json = JsonConvert.DeserializeObject<ForecastViewModel>(postalCode);

            return json;
        });
    }
}
