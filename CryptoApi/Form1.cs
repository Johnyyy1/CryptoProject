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

        //z�sk�n� coinu
        var apiHandler = new ApiHandler(); 
        Crypto? coin = await apiHandler.GetCrypto(coinName);

        //v�pis
        if (coin != null)
        {
            if (!string.IsNullOrEmpty(coin.Image?.Large))
            {
                pictureBoxLogo.Load(coin.Image.Large);
            }

            lblCoinInfo.Text = $"N�zev: {coin.Name} ({coin.Symbol.ToUpper()})\nCena : {coin.Market_Data.Current_Price["usd"]} USD";
        }
        else
        {
            MessageBox.Show("Nepoda�ilo se na��st informace o kryptom�n�.");
        }
    }
    private void LoadLastSearch() //v�pis posledn�ho vyhled�n� po zapnut�
    {
        loadData.Load("logs.txt", txtCoinName);
    }

    private void Savebtn_Click(object sender, EventArgs e)
    {
        saveData.Save("logs.txt", txtCoinName);
    }
}
