using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using XamlBrewer.Universal.ConditionalXaml.ViewModels;

namespace XamlBrewer.Universal.ConditionalXaml
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.GaugeSection.Loaded += this.GaugeSection_Loaded;
        }

        /// <summary>
        /// Too early.
        /// </summary>
        // protected override void OnApplyTemplate()
        // {
        //     base.OnApplyTemplate();
        //     this.GaugeSection_Loaded(this, null);
        // }

        private void GaugeSection_Loaded(object sender, RoutedEventArgs e)
        {
            // Reset data context. Not good enough.
            // var context = this.GaugeSection.DataContext;
            // this.GaugeSection.DataContext = null;
            // this.GaugeSection.DataContext = context;

            // Too early.
            // var rocket = this.GaugeSection.DataContext as TintinRocket;
            // rocket.Height = 130;

            // Trigger change notification to activate the conditional bindings.
            var preferences = this.Resources["Preferences"] as Preferences;
            
            // This is not enough.
            // preferences.Refresh();
            
            // It looks like you really have to change bound properties.
            preferences.IsMetric = !preferences.IsMetric;
        }
    }
}
