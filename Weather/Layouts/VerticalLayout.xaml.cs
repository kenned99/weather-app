using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather.Layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerticalLayout : Grid
    {
        public VerticalLayout(DataContext dataContext)
        {
            InitializeComponent();

            UpdateContext(dataContext);

            dataContext.PropertyChanged += (object sender, System.ComponentModel.PropertyChangedEventArgs e) => UpdateContext(dataContext);
        }

        private void UpdateContext(DataContext dataContext)
        {
            lblLocation.Text = dataContext.Location;
            BindingContext = dataContext.WeatherForeCast;
        }
    }
}