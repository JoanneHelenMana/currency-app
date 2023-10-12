namespace currency_app;

public partial class MainPage : ContentPage
{
    CoinConverterModel model = new CoinConverterModel();
    APIService service = new APIService();

    int oneDollarCoin = 1;
    double fiftyCentCoin = 0.5;
    double tenCentCoin = 0.1;
    double fiveCentCoin = 0.05;


    public MainPage()
	{
		InitializeComponent();
        InitUI();
    }

    private async Task InitUI()
    {
        pickerCurrency.IsEnabled = false;
        pickerCurrency.ItemsSource = await service.GetSymbols();
        pickerCurrency.IsEnabled = true;
    }

    /// <summary>
    /// Updates the one dollar labels on the UI.
    /// </summary>
    private void UpdateOneDollarLabels()
    {
        labelAmountOneDollar.Text = "(" + model.Dollar.ToString() + ")";
        labelTotalOneDollar.Text = "$" + (model.Dollar * oneDollarCoin).ToString();
    }

    /// <summary>
    /// Updates the fifty cent labels on the UI.
    /// </summary>
    private void UpdateFiftyCentLabels()
    {
        labelAmountFiftyCent.Text = "(" + model.FiftyCent.ToString() + ")";
        labelTotalFiftyCent.Text = "$" + (model.FiftyCent * fiftyCentCoin).ToString("0.00") + "c";
    }

    /// <summary>
    /// Updates the ten cent labels on the UI.
    /// </summary>
    private void UpdateTenCentLabels()
    {
        labelAmountTenCent.Text = "(" + model.TenCent.ToString() + ")";
        labelTotalTenCent.Text = "$" + (model.TenCent * tenCentCoin).ToString("0.00") + "c";
    }

    /// <summary>
    /// Updates the five cent labels on the UI.
    /// </summary>
    private void UpdateFiveCentLabels()
    {
        labelAmountFiveCent.Text = "(" + model.FiveCent.ToString() + ")";
        labelTotalFiveCent.Text = "$" + (model.FiveCent * fiveCentCoin).ToString("0.00") + "c";
    }

    /// <summary>
    /// Updates the total amount label on the UI.
    /// </summary>
    /// <param name="coin"></param>
    private void UpdateTotalAmountLabel(double coin)
    {
        double totalAmount = model.GetTotalAmount(coin);

        labelTotal.Text = "$" + totalAmount.ToString("0.00") + "c";
        labelAUD.Text = totalAmount.ToString("0.00") + " " + "AUD";
    }

    /// <summary>
    /// Triggered when the plus sign is clicked on the one dollar section. It adds one dollar coin to the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void addOneDollar_Clicked(object sender, EventArgs e)
    {
        model.AddDollar();
        UpdateOneDollarLabels();
        UpdateTotalAmountLabel(oneDollarCoin);
    }

    /// <summary>
    /// Triggered when the minus sign is clicked on the one dollar section. It subtracts one dollar coin from the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void subtractOneDollar_Clicked(object sender, EventArgs e)
    {
        if (model.Dollar >= 1)
        {
            model.SubtractDollar();
            UpdateOneDollarLabels();
            UpdateTotalAmountLabel(-oneDollarCoin);
        }
    }

    /// <summary>
    /// Triggered when the triangle up is clicked on the one dollar section. It converts two fifty cent coins into a dollar coin, and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void convertUpOneDollar_Clicked(object sender, EventArgs e)
    {
        if (model.FiftyCent >= 2)   // minimum amount of fifty cent coins for conversion
        {
            model.ConvertUpDollar();
            UpdateOneDollarLabels();
            UpdateFiftyCentLabels();
        }
    }

    /// <summary>
    /// Triggered when the triangle down is clicked on the one dollar section. It converts a dollar coin into two fifty cent coins, and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void convertDownOneDollar_Clicked(object sender, EventArgs e)
    {
        if (model.Dollar >= 1)  // minimum amount of dollar coins for conversion
        {
            model.CovertDownDollar();
            UpdateOneDollarLabels();
            UpdateFiftyCentLabels();
        }
    }

    /// <summary>
    /// Triggered when the plus sign is clicked on the fifty cent section. It adds one fifty cent coin to the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void addFiftyCent_Clicked(object sender, EventArgs e)
    {
        model.AddFiftyCent();
        UpdateFiftyCentLabels();
        UpdateTotalAmountLabel(fiftyCentCoin);
    }

    /// <summary>
    /// Triggered when the minus sign is clicked on the fifty cent section. It subtracts a fifty cent coin from the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void subtractFiftyCent_Clicked(object sender, EventArgs e)
    {
        if (model.FiftyCent >= 1)
        {
            model.SubtractFiftyCent();
            UpdateFiftyCentLabels();
            UpdateTotalAmountLabel(-fiftyCentCoin);
        }
    }

    /// <summary>
    /// Triggered when the triangle up is clicked on the fifty cent section. It converts five ten cent coins into a fifty cent coin, and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void convertUpFiftyCent_Clicked(object sender, EventArgs e)
    {
        if (model.TenCent >= 5) // minimum amount of ten cent coins for conversion
        {
            model.ConvertUpFiftyCent();
            UpdateFiftyCentLabels();
            UpdateTenCentLabels();
        }
    }

    /// <summary>
    /// Triggered when the triangle down is clicked on the fifty cent section. It converts a fifty cent coin into five ten cent coins, and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void convertDownFiftyCent_Clicked(object sender, EventArgs e)
    {
        if (model.FiftyCent >= 1)  // minimum amount of fifty cent coins for conversion
        {
            model.CovertDownFiftyCent();
            UpdateFiftyCentLabels();
            UpdateTenCentLabels();
        }
    }

    /// <summary>
    /// Triggered when the plus sign is clicked on the ten cent section. It adds one ten cent coin to the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void addTenCent_Clicked(object sender, EventArgs e)
    {
        model.AddTenCent();
        UpdateTenCentLabels();
        UpdateTotalAmountLabel(tenCentCoin);
    }

    /// <summary>
    /// Triggered when the minus sign is clicked on the ten cent section. It subtracts a ten cent coin from the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void subtractTenCent_Clicked(object sender, EventArgs e)
    {
        if (model.TenCent >= 1)
        {
            model.SubtractTenCent();
            UpdateTenCentLabels();
            UpdateTotalAmountLabel(-tenCentCoin);
        }
    }

    /// <summary>
    /// Triggered when the triangle up is clicked on the ten cent section. It converts two five cent coins into a ten cent coin, and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void convertUpTenCent_Clicked(object sender, EventArgs e)
    {
        if (model.FiveCent >= 2) // minimum amount of five cent coins for conversion
        {
            model.ConvertUpTenCent();
            UpdateTenCentLabels();
            UpdateFiveCentLabels();
        }
    }

    /// <summary>
    /// Triggered when the triangle down is clicked on the ten cent section. It converts a ten cent coin into two five cent coins, and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void convertDownTenCent_Clicked(object sender, EventArgs e)
    {
        if (model.TenCent >= 1)  // minimum amount of ten cent coins for conversion
        {
            model.CovertDownTenCent();
            UpdateTenCentLabels();
            UpdateFiveCentLabels();
        }
    }

    /// <summary>
    /// Triggered when the plus sign is clicked on the ten cent section. It adds one ten cent coin to the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void addFiveCent_Clicked(object sender, EventArgs e)
    {
        model.AddFiveCent();
        UpdateFiveCentLabels();
        UpdateTotalAmountLabel(fiveCentCoin);
    }

    /// <summary>
    /// Triggered when the minus sign is clicked on the ten cent section. It subtracts a ten cent coin from the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void subtractFiveCent_Clicked(object sender, EventArgs e)
    {
        if (model.FiveCent >= 1)
        {
            model.SubtractFiveCent();
            UpdateFiveCentLabels();
            UpdateTotalAmountLabel(-fiveCentCoin);
        }
    }

    /// <summary>
    /// Resets all values back to default (zero).
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonReset_Clicked(object sender, EventArgs e)
    {
        model.Dollar = 0;
        model.FiftyCent = 0;
        model.TenCent = 0;
        model.FiveCent = 0;
        model.TotalAmount = 0;
        labelTotal.Text = "$0.00c";

        UpdateOneDollarLabels();
        UpdateFiftyCentLabels();
        UpdateTenCentLabels();
        UpdateFiveCentLabels();
    }

    /// <summary>
    /// This is triggered when the currency selection changes. The user selects a currency to convert to, 
    /// and the program displays the converted amount with the appropriate symbol and currency.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void pickerCurrency_SelectedIndexChanged(object sender, EventArgs e)
    {
        char[] delimiterChars = { '$', 'c' }; 
        string[] amount = labelTotal.Text.Split(delimiterChars);

        float convertedAmount = await service.Convert(float.Parse(amount[1].Trim()), ((Currency)pickerCurrency.SelectedItem).Symbol);

        labelExchange.Text = $"{convertedAmount} {((Currency)pickerCurrency.SelectedItem).Symbol}";
    }
}
