using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using BusinessModel;
using Weather.Interfaces;
using Weather.ValueConterters;
using Weather.Layouts;
using DomainModel;

namespace Weather
{
    public partial class MainPage : ContentPage
    {
        private double _Width = 0;
        private double _Height = 0;
        
        private DataContext DataContext = new DataContext();

        public MainPage()
        {
            InitializeComponent();

            refreshView.Command = new Command(GetLocation);

            GetLocation();
        }

        private async void GetLocation()
        {
            try
            {
                var gpsDependencyService = DependencyService.Get<IGpsDependencyService>();
                if (!gpsDependencyService.IsGpsEnable())
                    gpsDependencyService.OpenSettings();

                // Start loadin icon
                refreshView.IsRefreshing = true;

                var location = await Geolocation.GetLocationAsync();
                if (location != null)
                {
                    var data = await new API().GetWeatherForeCastAsync(
                        Latitude: location.Latitude,
                        Longitude: location.Longitude,
                        Altitude: location.Altitude ?? 0);

                    //Locate city and country
                    var placemark = (await Geocoding.GetPlacemarksAsync(location.Latitude, location.Longitude))?.FirstOrDefault();
                    DataContext.Location = $"{placemark?.Locality}, {placemark?.CountryName}";

                    // Remove curernt day
                    data.Daily.RemoveAt(0);

                    DataContext.WeatherForeCast = data;                    
                    content.IsVisible = true;
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
            finally
            {
                // Stop loadin icon
                refreshView.IsRefreshing = false;                
            }
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            
            if (width != _Width && height != _Height)
            {
                _Width = width;
                _Height = height;

                if (width > height)
                    content.Content = new HorizontalLayout(DataContext);
                else
                    content.Content = new VerticalLayout(DataContext);
            }
        }
    }

    public class DataContext : INotifyPropertyChanged
    {
        private string _Location;
        private WeatherForeCast _WeatherForeCast;


        public event PropertyChangedEventHandler PropertyChanged;

        public string Location
        {
            get => _Location;
            set
            {
                if (value == _Location) return;

                _Location = value;
                NotifyPropertyChanged();
            }
        }
        
        public WeatherForeCast WeatherForeCast
        {
            get => _WeatherForeCast;
            set
            {
                if (value == _WeatherForeCast) return;

                _WeatherForeCast = value;
                NotifyPropertyChanged();
            }
        }
        
        private void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
