using Weather.Interfaces;
using Xamarin.Forms;
using CoreLocation;
using Weather.iOS;
using Foundation;
using UIKit;

[assembly: Dependency(typeof(GpsDependencyService))]
namespace Weather.iOS
{
    public class GpsDependencyService : IGpsDependencyService
    {
        public bool IsGpsEnable()
        {
            if (CLLocationManager.Status == CLAuthorizationStatus.Denied)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void OpenSettings()
        {
            var WiFiURL = new NSUrl("prefs:root=WIFI");

            if (UIApplication.SharedApplication.CanOpenUrl(WiFiURL))
            {   //> Pre iOS 10
                UIApplication.SharedApplication.OpenUrl(WiFiURL);
            }
            else
            {   //> iOS 10
                UIApplication.SharedApplication.OpenUrl(new NSUrl("App-Prefs:root=WIFI"));
            }
        }
    }
}