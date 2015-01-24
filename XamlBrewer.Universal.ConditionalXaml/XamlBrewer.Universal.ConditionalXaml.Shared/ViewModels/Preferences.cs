using Mvvm;

namespace XamlBrewer.Universal.ConditionalXaml.ViewModels
{
    public class Preferences : BindableBase
    {
        private bool isMetric = true;

        public bool IsMetric
        {
            get { return this.isMetric; }
            set { this.SetProperty(ref this.isMetric, value); }
        }
    }
}
