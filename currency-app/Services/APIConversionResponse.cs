using Newtonsoft.Json;

namespace currency_app.Services
{
    internal class APIConversionResponse
    {
        public class Rootobject
        {
            public string date { get; set; }
            public string historical { get; set; }
            public Info info { get; set; }
            public Query query { get; set; }

            [JsonProperty("result")]
            public float Result { get; set; }
            public bool success { get; set; }
        }

        public class Info
        {
            public float rate { get; set; }
            public int timestamp { get; set; }
        }

        public class Query
        {
            public float amount { get; set; }
            public string from { get; set; }
            public string to { get; set; }
        }
    }
}
