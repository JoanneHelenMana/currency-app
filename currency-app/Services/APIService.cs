using Newtonsoft.Json;
using System.Net.Http;


namespace currency_app.Services
{
    internal class APIService
    {
        const string baseURL = "https://api.apilayer.com/exchangerates_data/";
        string API_KEY = "1WKRl1tfaOW9CuTklxHVGXIuZ7eKdZrX";

        public APIService() { }

        public async Task<float> Convert(float amount, string symbol, string baseSymbol = "AUD")
        {
            string apiURL = baseURL + $"convert?to={symbol}&from={baseSymbol}&amount={amount}";

            string responseString = await GetResponse(apiURL);

            APIConversionResponse.Rootobject conversionResponse = JsonConvert.DeserializeObject<APIConversionResponse.Rootobject>(responseString);

            return conversionResponse.Result;
        }

        public async Task<Dictionary<string, string>> GetSymbols()
        {
            string fullURL = baseURL + "symbols";

            string responseString = await GetResponse(fullURL);

            APISymbolResponse symbolResponse = JsonConvert.DeserializeObject<APISymbolResponse>(responseString);

            return symbolResponse.Symbols;
        }

        private async Task<string> GetResponse(string url)
        {
            HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("apikey", API_KEY);

            HttpResponseMessage response = await client.SendAsync(request);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
