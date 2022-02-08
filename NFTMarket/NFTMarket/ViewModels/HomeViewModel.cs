using System;
using System.Collections.ObjectModel;
using NFTMarket.Models;

namespace NFTMarket.ViewModels
{
    public class HomeViewModel: BaseViewModel
    {
        private ObservableCollection<NFT> _nftList;
        public ObservableCollection<NFT> NFTList
        {
            get { return _nftList; }
            set { SetProperty(ref _nftList, value); }
        }
        public HomeViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            NFT nft = new NFT();
            NFTList = new ObservableCollection<NFT>(nft.GetNFTs());
        }
    }

}
