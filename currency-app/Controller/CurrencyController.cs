namespace currency_app
{
    /// <summary>
    /// The controller sets the functionality that interacts with the model.
    /// Functions include adding, subtracting, converting up and down for each coin value.
    /// Each function returns the amount held in the wallet.
    /// </summary>
    internal class CurrencyController
    {
        CurrencyModel model = new CurrencyModel(); 


        /// <summary>
        /// Adds a dollar coin.
        /// </summary>
        public CurrencyModel? AddDollar()
        {
            model.Dollar++;
            return model;
        }

        /// <summary>
        /// Subtracts a dollar coin.
        /// </summary>
        public CurrencyModel? SubtractDollar()
        {
            if (model.Dollar == 0) return null;
            model.Dollar--;
            return model;
        }

        /// <summary>
        /// Converts two fifty cent coins into a dollar coin.
        /// </summary>
        public CurrencyModel? ConvertUpDollar()
        {
            if (model.FiftyCent < 2) return null;
            else
            {
                model.FiftyCent -= 2;
                model.Dollar++;
                return model;
            }
        }

        /// <summary>
        /// Converts a dollar coin into two fifty cent coins.
        /// </summary>
        public CurrencyModel? CovertDownDollar()
        {
            if (model.Dollar == 0) return null;
            if (model.Dollar < 1) return null;
            else
            {
                model.Dollar--;
                model.FiftyCent += 2;
                return model;
            }
        }

        /// <summary>
        /// Adds a fifty cent coin.
        /// </summary>
        public CurrencyModel? AddFiftyCent()
        {
            model.FiftyCent++;
            return model;
        }

        /// <summary>
        /// Subtracts a fifty cent coin.
        /// </summary>
        public CurrencyModel? SubtractFiftyCent()
        {
            if (model.FiftyCent == 0) return null;
            model.FiftyCent--;
            return model;
        }

        /// <summary>
        /// Converts five ten cent coins into a fifty cent coin.
        /// </summary>
        public CurrencyModel? ConvertUpFiftyCent()
        {
            if (model.TenCent < 5) return null;
            else
            {
                model.TenCent -= 5;
                model.FiftyCent++;
                return model;
            }
        }

        /// <summary>
        /// Converts a fifty cent coin into five ten cent coins.
        /// </summary>
        public CurrencyModel? CovertDownFiftyCent()
        {
            if (model.FiftyCent == 0) return null;
            if (model.FiftyCent < 1) return null;
            else
            {
                model.FiftyCent--;
                model.TenCent += 5;
                return model;
            }
        }

        /// <summary>
        /// Adds a ten cent coin.
        /// </summary>
        public CurrencyModel? AddTenCent()
        {
            model.TenCent++;
            return model;
        }

        /// <summary>
        /// Subtracts a ten cent coin.
        /// </summary>
        public CurrencyModel? SubtractTenCent()
        {
            if (model.TenCent == 0) return null;
            model.TenCent--;
            return model;
        }

        /// <summary>
        /// Converts two five cent coins into a ten cent coin.
        /// </summary>
        public CurrencyModel? ConvertUpTenCent()
        {
            if (model.FiveCent < 2) return null;
            else
            {
                model.FiveCent -= 2;
                model.TenCent++;
                return model;
            }
        }

        /// <summary>
        /// Converts a ten cent coin into two five cent coins.
        /// </summary>
        public CurrencyModel? CovertDownTenCent()
        {
            if (model.TenCent == 0) return null;
            else
            {
                model.TenCent--;
                model.FiveCent += 2;
                return model;
            }
        }

        /// <summary>
        /// Adds a five cent coin.
        /// </summary>
        public CurrencyModel? AddFiveCent()
        {
            model.FiveCent++;
            return model;
        }

        /// <summary>
        /// Subtracts a five cent coin.
        /// </summary>
        public CurrencyModel? SubtractFiveCent()
        {
            if (model.FiveCent == 0) return null;
            model.FiveCent--;
            return model;
        }

        public double GetTotalAmount()
        {
            return model.TotalAmount;
        }

        public CurrencyModel? ResetAllValues()
        {
            model.Dollar = 0;
            model.FiftyCent = 0;
            model.TenCent = 0;
            model.FiveCent = 0;
            return model;
        }
    }
}
