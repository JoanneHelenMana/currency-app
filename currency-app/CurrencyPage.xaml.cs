namespace currency_app;

public partial class CurrencyPage : ContentPage
{
    CurrencyController controller = new CurrencyController();
    APIService service = new APIService();

    int oneDollarCoin = 1;
    double fiftyCentCoin = 0.5;
    double tenCentCoin = 0.1;
    double fiveCentCoin = 0.05;


    public CurrencyPage()
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
    /// Updates all labels on the UI for amount of coins and totals for each value.
    /// </summary>
    private void UpdateLabels(CurrencyModel? model)
    {
        if (model == null) return;
        labelAmountOneDollar.Text = "(" + model.Dollar.ToString() + ")";
        labelTotalOneDollar.Text = "$" + (model.Dollar * oneDollarCoin).ToString();
        labelAmountFiftyCent.Text = "(" + model.FiftyCent.ToString() + ")";
        labelTotalFiftyCent.Text = "$" + (model.FiftyCent * fiftyCentCoin).ToString("0.00") + "c";
        labelAmountTenCent.Text = "(" + model.TenCent.ToString() + ")";
        labelTotalTenCent.Text = "$" + (model.TenCent * tenCentCoin).ToString("0.00") + "c";
        labelAmountFiveCent.Text = "(" + model.FiveCent.ToString() + ")";
        labelTotalFiveCent.Text = "$" + (model.FiveCent * fiveCentCoin).ToString("0.00") + "c";
        UpdateTotalAmountLabel();
    }

    /// <summary>
    /// Updates the total amount label on the UI.
    /// </summary>
    /// <param name="coin"></param>
    private void UpdateTotalAmountLabel()
    {
        double totalAmount = controller.GetTotalAmount();

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
        UpdateLabels(controller.AddDollar());
    }

    /// <summary>
    /// Triggered when the minus sign is clicked on the one dollar section. It subtracts one dollar coin from the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void subtractOneDollar_Clicked(object sender, EventArgs e)
    { 
        UpdateLabels(controller.SubtractDollar());
    }

    /// <summary>
    /// Triggered when the triangle up is clicked on the one dollar section. It converts two fifty cent coins into a dollar coin, and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void convertUpOneDollar_Clicked(object sender, EventArgs e)
    {
        UpdateLabels(controller.ConvertUpDollar());
    }

    /// <summary>
    /// Triggered when the triangle down is clicked on the one dollar section. It converts a dollar coin into two fifty cent coins, and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void convertDownOneDollar_Clicked(object sender, EventArgs e)
    {
        UpdateLabels(controller.CovertDownDollar());
    }

    /// <summary>
    /// Triggered when the plus sign is clicked on the fifty cent section. It adds one fifty cent coin to the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void addFiftyCent_Clicked(object sender, EventArgs e)
    {
        UpdateLabels(controller.AddFiftyCent());
    }

    /// <summary>
    /// Triggered when the minus sign is clicked on the fifty cent section. It subtracts a fifty cent coin from the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void subtractFiftyCent_Clicked(object sender, EventArgs e)
    {
        UpdateLabels(controller.SubtractFiftyCent());
    }

    /// <summary>
    /// Triggered when the triangle up is clicked on the fifty cent section. It converts five ten cent coins into a fifty cent coin, and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void convertUpFiftyCent_Clicked(object sender, EventArgs e)
    {
        UpdateLabels(controller.ConvertUpFiftyCent());
    }

    /// <summary>
    /// Triggered when the triangle down is clicked on the fifty cent section. It converts a fifty cent coin into five ten cent coins, and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void convertDownFiftyCent_Clicked(object sender, EventArgs e)
    {
        UpdateLabels(controller.CovertDownFiftyCent());
    }

    /// <summary>
    /// Triggered when the plus sign is clicked on the ten cent section. It adds one ten cent coin to the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void addTenCent_Clicked(object sender, EventArgs e)
    {
        UpdateLabels(controller.AddTenCent());
    }

    /// <summary>
    /// Triggered when the minus sign is clicked on the ten cent section. It subtracts a ten cent coin from the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void subtractTenCent_Clicked(object sender, EventArgs e)
    {
        UpdateLabels(controller.SubtractTenCent());
    }

    /// <summary>
    /// Triggered when the triangle up is clicked on the ten cent section. It converts two five cent coins into a ten cent coin, and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void convertUpTenCent_Clicked(object sender, EventArgs e)
    {
        UpdateLabels(controller.ConvertUpTenCent());
    }

    /// <summary>
    /// Triggered when the triangle down is clicked on the ten cent section. It converts a ten cent coin into two five cent coins, and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void convertDownTenCent_Clicked(object sender, EventArgs e)
    {
        UpdateLabels(controller.CovertDownTenCent());
    }

    /// <summary>
    /// Triggered when the plus sign is clicked on the ten cent section. It adds one ten cent coin to the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void addFiveCent_Clicked(object sender, EventArgs e)
    {
        UpdateLabels(controller.AddFiveCent());
    }

    /// <summary>
    /// Triggered when the minus sign is clicked on the ten cent section. It subtracts a ten cent coin from the wallet and updates the UI.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void subtractFiveCent_Clicked(object sender, EventArgs e)
    {
        UpdateLabels(controller.SubtractFiveCent());
    }

    /// <summary>
    /// Resets all values back to default (zero).
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonReset_Clicked(object sender, EventArgs e)
    {
        UpdateLabels(controller.ResetAllValues());
        UpdateLabels(controller.ResetAllValues());
        UpdateLabels(controller.ResetAllValues());
        UpdateLabels(controller.ResetAllValues());
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

        float convertedAmount = await service.Convert(float.Parse(amount[1].Trim()), ((CurrencyController)pickerCurrency.SelectedItem).Symbol);

        labelExchange.Text = $"{convertedAmount} {((CurrencyController)pickerCurrency.SelectedItem).Symbol}";
    }
}
