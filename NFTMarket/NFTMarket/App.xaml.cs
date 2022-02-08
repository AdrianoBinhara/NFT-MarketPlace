using System;
using NFTMarket.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NFTMarket
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Sharpnado.MaterialFrame.Initializer.Initialize(loggerEnable: false, debugLogEnable: false);

            MainPage = new NavigationPage(new WelcomePage());
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
