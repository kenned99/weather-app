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

            GetLocation();
        }

        private async void GetLocation() 
        {
            try
            {
                var gpsDependencyService = DependencyService.Get<IGpsDependencyService>();
                if (!gpsDependencyService.IsGpsEnable())
                    gpsDependencyService.OpenSettings();

                var location = await Geolocation.GetLocationAsync();
                if (location != null)
                {
                    var data = await new API().GetWeatherForeCastAsync(
                        Latitude: location.Latitude, 
                        Longitude: location.Longitude, 
                        Altitude: location.Altitude ?? 0);

                    var placemark = (await Geocoding.GetPlacemarksAsync(location.Latitude, location.Longitude))?.FirstOrDefault();
                    lblLocation.Text = $"{placemark?.Locality}, {placemark?.CountryName}";

                    //data.Daily = data.Daily?.Skip(1).Take(5).ToList();
                    data.Daily.RemoveAt(0);

                    BindingContext = data;
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
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            GetLocation();
        }
    }
}
