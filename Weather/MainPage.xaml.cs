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

namespace Weather
{
    public partial class MainPage : ContentPage
    {
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
                    lblLocation.Text = $"{placemark?.Locality}, {placemark?.CountryName}";

                    // Remove curernt day
                    data.Daily.RemoveAt(0);

                    BindingContext = data;

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
    }
}
