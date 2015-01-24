namespace XamlBrewer.Universal.ConditionalXaml.ViewModels
{
    using Mvvm;

    public class TintinRocket : BindableBase
    {
        private double speed;
        private double height;

        public TintinRocket()
        {
            this.Speed = 13000;
            this.Height = 125;
        }

        /// <summary>
        /// Gets or sets the speed in kilometers per second.
        /// </summary>
        public double Speed
        {
            get { return this.speed; }
            set
            {
                this.SetProperty(ref this.speed, value);
                this.OnPropertyChanged("SpeedInMiles");
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                this.SetProperty(ref this.height, value);
                this.OnPropertyChanged("HeightInFeet");
            }
        }

        /// <summary>
        /// Gets the speed in miles per second.
        /// </summary>
        public double SpeedInMiles
        {
            get { return this.Speed * 0.62137119; }
        }

        /// <summary>
        /// Gets the height in feet.
        /// </summary>
        public double HeightInFeet
        {
            get { return this.Height * 3.2808399; }
        }
    }
}
