using Mvvm;

namespace XamlBrewer.Universal.ConditionalXaml.ViewModels
{
    public class Preferences : BindableBase
    {
        private bool isMetric = true;

        /// <summary>
        /// Gets or sets a value indicating whether or not we're using the metric system.
        /// </summary>
        public bool IsMetric
        {
            get { return this.isMetric; }
            set { this.SetProperty(ref this.isMetric, value); }
        }

        /// <summary>
        /// Triggers a change notification.
        /// </summary>
        public void Refresh()
        {
            this.OnPropertyChanged("IsMetric");
        }
    }
}
