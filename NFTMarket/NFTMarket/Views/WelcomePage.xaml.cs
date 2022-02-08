using System;
using System.Collections.Generic;
using NFTMarket.ViewModels;
using Xamarin.Forms;

namespace NFTMarket.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            BindingContext = new WelcomeViewModel();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}
