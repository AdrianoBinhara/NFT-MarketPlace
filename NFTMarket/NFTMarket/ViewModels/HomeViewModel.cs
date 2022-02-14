using System;
using System.Collections.ObjectModel;
using NFTMarket.Models;

namespace NFTMarket.ViewModels
{
    public class HomeViewModel: BaseViewModel
    {
        private ObservableCollection<NFT> _nftList;
        public ObservableCollection<NFT> TrendingList
        {
            get { return _nftList; }
            set { SetProperty(ref _nftList, value); }
        }

        private ObservableCollection<NFT> _topSellerList;
        public ObservableCollection<NFT> TopSellerList
        {
            get { return _topSellerList; }
            set { SetProperty(ref _topSellerList, value); }
        }

        private ObservableCollection<NFT> _NFTList;
        public ObservableCollection<NFT> NFTList
        {
            get { return _NFTList; }
            set { SetProperty(ref _NFTList, value); }
        }

        public HomeViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            NFT nft = new NFT();
            TrendingList = new ObservableCollection<NFT>(nft.GetTrendingNFTs());
            TopSellerList = new ObservableCollection<NFT>(nft.GetTopSeller());
            NFTList = new ObservableCollection<NFT>(nft.GetNFTList());
        }
    }

}
