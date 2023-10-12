using Newtonsoft.Json;


namespace currency_app
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

            APIRootResponse response = JsonConvert.DeserializeObject<APIRootResponse>(responseString);

            return response.Result;
        }

        public async Task<List<Currency>> GetSymbols()
        {
            string apiURL = baseURL + "symbols";

            string responseString = await GetResponse(apiURL);

            return JsonConvert.DeserializeObject<APISymbolResponse>(responseString).Symbols.Select(x => new Currency() { Symbol = x.Key, Name = x.Value }).ToList();
        }

        private async Task<string> GetResponse(string url)
        {
            HttpClient client = new();

            HttpRequestMessage request = new(HttpMethod.Get, url);
            request.Headers.Add("apikey", API_KEY);

            HttpResponseMessage response = await client.SendAsync(request);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
