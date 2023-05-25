using System;
namespace CryptoWallet
{
    public class Crypto
    {
        public string id { get; set; }
        public string image { get; set; }
        public double current_price { get; set; }
        public double market_cap_rank { get; set; }
        public double price_change_percentage_24h { get; set; }
    }
}

