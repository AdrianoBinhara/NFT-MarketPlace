using System;
using System.Collections.Generic;
using NFTMarket.ViewModels;
using Xamarin.Forms;

namespace NFTMarket.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }
    }
}
