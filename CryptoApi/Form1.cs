using Microsoft.VisualBasic.Logging;

namespace CryptoApi;

public partial class Form1 : Form
{
    //private string logFilePath = "logs.txt"; cesta

    SaveData saveData = new SaveData();
    LoadData loadData = new LoadData();

    public Form1()
    {
        InitializeComponent();
        LoadLastSearch();
    }

    private async void btnGetInfo_Click(object sender, EventArgs e)
    {
        string coinName = txtCoinName.Text.ToLower();

        //získání coinu
        var apiHandler = new ApiHandler(); 
        Crypto? coin = await apiHandler.GetCrypto(coinName);

        //výpis
        if (coin != null)
        {
            if (!string.IsNullOrEmpty(coin.Image?.Large))
            {
                pictureBoxLogo.Load(coin.Image.Large);
            }

            lblCoinInfo.Text = $"Název: {coin.Name} ({coin.Symbol.ToUpper()})\nCena : {coin.Market_Data.Current_Price["usd"]} USD";
        }
        else
        {
            MessageBox.Show("Nepodaøilo se naèíst informace o kryptomìnì.");
        }
    }
    private void LoadLastSearch() //výpis posledního vyhledání po zapnutí
    {
        loadData.Load("logs.txt", txtCoinName);
    }

    private void Savebtn_Click(object sender, EventArgs e)
    {
        saveData.Save("logs.txt", txtCoinName);
    }
}
