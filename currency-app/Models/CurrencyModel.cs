namespace currency_app
{
    /// <summary>
    /// The model stores amounts of coins for each value and the total amount of money held in the 'wallet'.
    /// </summary>
    internal class CurrencyModel
    {
        int dollar = 0;
        public int Dollar 
        { 
            get 
            {
                return dollar;
            }
            set
            {
                dollar = value;
                if (dollar < 0) dollar = 0;
            }                
        }

        int fiftyCent = 0;
        public int FiftyCent
        {
            get
            {
                return fiftyCent;
            }
            set
            {
                fiftyCent = value;
                if (fiftyCent < 0) fiftyCent = 0;
            }
        }

        int tenCent = 0;
        public int TenCent
        {
            get
            {
                return tenCent;
            }
            set
            {
                tenCent = value;
                if (tenCent < 0) tenCent = 0;
            }
        }

        int fiveCent = 0;
        public int FiveCent
        {
            get
            {
                return fiveCent;
            }
            set
            {
                fiveCent = value;
                if (fiveCent < 0) fiveCent = 0;
            }
        }

        double fiftyCentValue = 0.5;
        double tenCentValue = 0.1;
        double fiveCentValue = 0.05;
        public double TotalAmount
        {
            get
            {
                return dollar + (fiftyCent * fiftyCentValue) + (tenCent * tenCentValue) + (fiveCent * fiveCentValue);
            }
        }
    }
}
