namespace currency_app
{
    internal class Currency
    {
        public string Symbol { get; set; }
        public string Name { get; set; }


        public override string ToString()
        {
            return $"[{Symbol}] {Name}";
        }
    }
}
