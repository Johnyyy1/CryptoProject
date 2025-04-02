using RestSharp;
using System.Text.Json;
using Newtonsoft.Json;


namespace CryptoApi
{
    public class ApiHandler
    {
       
        public async Task<Crypto?> GetCrypto(string name)
        {
            try
            {
                RestClient client = new RestClient($"https://api.coingecko.com/api/v3/coins/{name}");
                RestRequest request = new RestRequest();

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    Console.WriteLine(response.Content);

                    Crypto coin = JsonConvert.DeserializeObject<Crypto>(response.Content);

                    return coin;
                }
                else
                {
                    Console.WriteLine($"Chyba: {response.StatusCode}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}