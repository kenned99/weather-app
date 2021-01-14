﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather.Layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerticalLayout : Grid
    {
        public VerticalLayout(DataContext dataContext)
        {
            InitializeComponent();

            dataContext.PropertyChanged += (object sender, System.ComponentModel.PropertyChangedEventArgs e) =>
            {
                lblLocation.Text = dataContext.Location;
                BindingContext = dataContext.WeatherForeCast;
            };
        }
    }
}