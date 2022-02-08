using System;
using System.Collections.Generic;

namespace NFTMarket.Models
{
    public class NFT
    {
        private void GetNFTs()
        {
            new List<NFT>()
            {
                new NFT{ Name = "Azumi", Value =  200055.02, Valuation = 3.99},
                new NFT{ Name = "Hape prime", Value = 180055.45, Valuation = 33.79},
                new NFT{ Name = "Cryoto", Value = 90055.62, Valuation = -6.56},
                new NFT{ Name = "Ape Club", Value = 88055.12, Valuation = 3.99},
                new NFT{ Name = "Bat", Value = 10055.06, Valuation = 3.99},
                new NFT{ Name = "Mutant", Value = 9095.27, Valuation = 3.99}
            };
        }

        public string Name { get; set; }
        public double Value { get; set; }
        public object Valuation { get; set; }
        public int Likes { get; set; }
    }
}
