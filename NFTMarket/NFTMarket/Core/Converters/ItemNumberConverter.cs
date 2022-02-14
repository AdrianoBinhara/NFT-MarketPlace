using System;
using System.Globalization;
using NFTMarket.Models;
using NFTMarket.ViewModels;
using Xamarin.Forms;

namespace NFTMarket.Core.Converters
{
    public class ItemNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is Binding binding &&
             value is NFT nft &&
             binding.Source is CollectionView collectionView &&
             collectionView.BindingContext is HomeViewModel viewModel)
            {
                return viewModel.NFTList.IndexOf(nft) + 1;
            }

            return -1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
