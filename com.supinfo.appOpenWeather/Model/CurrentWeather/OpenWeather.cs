using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using com.supinfo.appOpenWeather.Annotations;
using com.supinfo.appOpenWeather.ViewModel;
using Newtonsoft.Json;

namespace com.supinfo.appOpenWeather.Model.CurrentWeather
{
    public class OpenWeather
    {
        #region Attribut
        private int _id;
        private string _name;
        private int _cod;
        private string _base;
        private string _visibility;
        private string _dt;
        private Coord _coord;
        private List<Weather> _weather;
        private Main _main;
        private Wind _wind;
        private City _city;
        private Clouds _clouds;
        private Sys _sys;
        private Dictionary<string, string> _countries;
        private Forecasts.Forecasts _forecasts;
        #endregion
        
        #region Propriete
        public ref int Id => ref _id;
        public ref string Name => ref _name;
        public ref int Cod => ref _cod;
        public ref string Base => ref _base;
        public ref string Visibility => ref _visibility;
        public ref string Dt => ref _dt;
        public ref Coord Coord => ref _coord;
        public ref List<Weather> Weather => ref _weather;
        public ref Main Main => ref _main;
        public ref Wind Wind => ref _wind;
        public ref Clouds Clouds => ref _clouds;
        public ref City City => ref _city;
        public ref Sys Sys => ref _sys;
        public ref Dictionary<string, string> Countries => ref _countries;
        public ref Forecasts.Forecasts Forecasts => ref _forecasts;
        #endregion

        public OpenWeather(int id, string name, int cod, string @base, string visibility, string dt, Coord coord, List<Weather> weather, Main main, Wind wind, Clouds clouds, City city, Sys sys, Dictionary<string, string> countries)
        {
            this._id = id;
            this.Name = name;
            this.Cod = cod;
            this.Base = @base;
            this.Visibility = visibility;
            this.Dt = dt;
            this.Coord = coord;
            this.Weather = weather;
            this.Main = main;
            this.Wind = wind;
            this.City = city;
            this.Clouds = clouds;
            this.Sys = sys;
            this.Countries = countries;
        }

        public OpenWeather()
        {

        }

        public OpenWeather(OpenWeather weather)
        {
            this._id = weather.Id;
            this.Name = weather.Name;
            this.Cod = weather.Cod;
            this.Base = weather.Base;
            this.Visibility = weather.Visibility;
            this.Dt = weather.Dt;
            this.Coord = weather.Coord;
            this.Weather = weather.Weather;
            this.Main = weather.Main;
            this.Wind = weather.Wind;
            this.City = weather.City;
            this.Clouds = weather.Clouds;
            this.Sys = weather.Sys;
        }
    }
}
