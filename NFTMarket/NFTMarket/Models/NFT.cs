using System;
using System.Collections.Generic;

namespace NFTMarket.Models
{
    public class NFT
    { 
        public List<NFT> GetTrendingNFTs()
        {
            return new List<NFT>()
            {
                new NFT{ Name = "3D Art", Image = "3DArt.png", Value = 88055.12, Valuation = 3.99, Likes = 234},
                new NFT{ Name = "Abstract Art", Image = "AbstractArt.png", Value = 10055.06, Valuation = 3.99, Likes = 121},
                new NFT{ Name = "Portrait Art", Image = "PortraitArt.png", Value = 9095.27, Valuation = 3.99, Likes = 112},
                new NFT{ Name = "Virtual", Image = "Virtual.png", Value = 9095.27, Valuation = 3.99, Likes  = 110}
            };
        }

        public List<NFT> GetTopSeller()
        {
            return new List<NFT>()
            {
                new NFT{ Name = "Wave", Image = "Wave.png", Value = 0.46, Valuation = 3.99, Likes = 200},
                new NFT{ Name = "Abstract Pink", Image = "AbstractPink.png", Value = 0.56, Valuation = 3.99, Likes = 129},
                new NFT{ Name = "WaveBlue", Image = "WaveBlue.png", Value = 0.233, Valuation = 3.99, Likes = 156},
                new NFT{ Name = "Abstract23", Image = "Abstract23.png", Value = 0.49, Valuation = 3.99, Likes =136}
            };
        }

        public string Name { get; set; }
        public double Value { get; set; }
        public object Valuation { get; set; }
        public int Likes { get; set; }
        public string Image { get; set; }
    }
}
