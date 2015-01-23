namespace XamlBrewer.Universal.ConditionalXaml.ViewModels
{
    using Mvvm;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TintinRocket : BindableBase
    {
        public TintinRocket()
        {
            this.Speed = 13000;
            this.Height = 125;
        }

        public double Speed { get; set; }
        public double Height { get; set; }

        public double SpeedInMiles
        {
            get { return this.Speed * 0.62137119; }
        }

        public double HeightInFeet
        {
            get { return this.Height * 3.2808399; }
        }
    }
}
