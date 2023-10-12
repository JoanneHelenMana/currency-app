namespace currency_app
{
    internal class APISymbolResponse
    {
        public bool Success { get; set; }
        public Dictionary<string, string> Symbols { get; set; }
    }
}
