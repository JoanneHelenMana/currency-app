namespace currency_app
{
    /// <summary>
    /// The model stores amounts of coins and the total amount of money held in the 'wallet'. The methods handle actions and interactions for the coins.
    /// </summary>
    internal class CoinConverterModel
    {
        public int Dollar { get; set; }

        public int FiftyCent { get; set; }

        public int TenCent { get; set; }

        public int FiveCent { get; set; }

        public double TotalAmount { get; set; }


        public CoinConverterModel() { }


        /// <summary>
        /// Gets the total amount of money held.
        /// </summary>
        /// <param name="coin"></param>
        public double GetTotalAmount(double coin)
        {
            TotalAmount += coin;
            return TotalAmount;
        }

        /// <summary>
        /// Adds a dollar coin.
        /// </summary>
        public void AddDollar()
        {
            Dollar++;
        }

        /// <summary>
        /// Subtracts a dollar coin.
        /// </summary>
        public void SubtractDollar()
        {
            Dollar--;
        }

        /// <summary>
        /// Converts two fifty cent coins into a dollar coin.
        /// </summary>
        public void ConvertUpDollar()
        {
            FiftyCent -= 2;
            Dollar++;
        }

        /// <summary>
        /// Converts a dollar coin into two fifty cent coins.
        /// </summary>
        public void CovertDownDollar()
        {
            Dollar--;
            FiftyCent += 2;
        }

        /// <summary>
        /// Adds a fifty cent coin.
        /// </summary>
        public void AddFiftyCent()
        {
            FiftyCent++;
        }

        /// <summary>
        /// Subtracts a fifty cent coin.
        /// </summary>
        public void SubtractFiftyCent()
        {
            FiftyCent--;
        }

        /// <summary>
        /// Converts five ten cent coins into a fifty cent coin.
        /// </summary>
        public void ConvertUpFiftyCent()
        {
            TenCent -= 5;
            FiftyCent++;
        }

        /// <summary>
        /// Converts a fifty cent coin into five ten cent coins.
        /// </summary>
        public void CovertDownFiftyCent()
        {
            FiftyCent--;
            TenCent += 5;
        }

        /// <summary>
        /// Adds a ten cent coin.
        /// </summary>
        public void AddTenCent()
        {
            TenCent++;
        }

        /// <summary>
        /// Subtracts a ten cent coin.
        /// </summary>
        public void SubtractTenCent()
        {
            TenCent--;
        }

        /// <summary>
        /// Converts two five cent coins into a ten cent coin.
        /// </summary>
        public void ConvertUpTenCent()
        {
            FiveCent -= 2;
            TenCent++;
        }

        /// <summary>
        /// Converts a ten cent coin into two five cent coins.
        /// </summary>
        public void CovertDownTenCent()
        {
            TenCent--;
            FiveCent += 2;
        }

        /// <summary>
        /// Adds a five cent coin.
        /// </summary>
        public void AddFiveCent()
        {
            FiveCent++;
        }

        /// <summary>
        /// Subtracts a five cent coin.
        /// </summary>
        public void SubtractFiveCent()
        {
            FiveCent--;
        }
    }
}
