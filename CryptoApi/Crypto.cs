using RestSharp;
using Newtonsoft.Json;


namespace CryptoApi
{
    public class Crypto
    {
        public string Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public CoinImage Image { get; set; }
        public MarketData Market_Data { get; set; }
    }

    public class CoinImage
    {
        // velikosti obrazku
        public string Thumb { get; set; }
        public string Small { get; set; }
        public string Large { get; set; }
    }

    public class MarketData
    {
        // market cena
        public Dictionary<string, decimal> Current_Price { get; set; }  
    }
}
