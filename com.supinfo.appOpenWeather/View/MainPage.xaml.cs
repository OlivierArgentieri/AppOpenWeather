using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using com.supinfo.appOpenWeather.ViewModel;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace com.supinfo.appOpenWeather
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {

            this.InitializeComponent();
            this.LoadCountrisTask();

        }

        private async void ButonSearchLatitudeLongitude_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                DataContext = await OpenWeatherViewModel.GetWeatherAsync(((ComboBoxItem)ComboBoxCountry.SelectedItem).Tag.ToString(), this.TextBoxPostalCode.Text);

            }
            catch (System.Net.Http.HttpRequestException exception)
            {
#if DEBUG
                Console.WriteLine(exception);
#endif
            }
        }
         
        private async void LoadCountrisTask()
        {
            var l = await OpenWeatherViewModel.GetCountriesAsync();
            foreach (var x in l.OrderBy(y => y.Value))
            {
                this.ComboBoxCountry.Items.Add(new ComboBoxItem { Tag = x.Key, Content = x.Value });
            }
            this.ComboBoxCountry.IsTextSearchEnabled = true;
        }
    }
}
