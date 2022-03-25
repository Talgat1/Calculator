using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculator
{
    public partial class App : Application
    {
        Calc calc;
        public App()
        {
            InitializeComponent();
            calc = new Calc();
            calc.RestoreState(Current.Properties);
            MainPage = new MainPage(calc);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
