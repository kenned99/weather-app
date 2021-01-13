using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Weather.ValueConterters
{
    public class GetWindDirectionDiscription : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int val)
            {
                var fromDirection = string.Empty;
                switch (val)
                {
                    case int n when n == 0 || n == 360:
                        fromDirection = "north";
                        break;
                    case int n when 0 < n && n < 90:
                        fromDirection = "north east";
                        break;
                    case int n when n == 90:
                        fromDirection = "east";
                        break;
                    case int n when 90 < n && n < 180:
                        fromDirection = "south east";
                        break;
                    case int n when n == 180:
                        fromDirection = "south";
                        break;
                    case int n when 180 < n && n < 270:
                        fromDirection = "south vest";
                        break;
                    case int n when n == 270:
                        fromDirection = "vest";
                        break;
                    case int n when 270 < n && n < 360:
                        fromDirection = "north vest";
                        break;
                };

                return $"From {fromDirection}";
            }
            
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
