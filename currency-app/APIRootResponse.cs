namespace currency_app
{
    internal class APIRootResponse
    {
        public string Date { get; set; }
        public Info Info { get; set; }
        public Query Query { get; set; }
        public float Result { get; set; }
        public bool Success { get; set; }
        public bool Historial { get; set; }
    }

    public class Info
    {
        public float Rate { get; set; }
        public int Timestamp { get; set; }
    }

    public class Query
    {
        public int Amount { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}
