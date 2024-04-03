using Newtonsoft.Json;

namespace currency_app.Services
{
    internal class APISymbolResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("symbols")]
        public Dictionary<string, string> Symbols { get; set; }
    }
}
