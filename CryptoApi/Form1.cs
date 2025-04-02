using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CryptoApi;

public partial class Form1 : Form
{
    private string logFilePath = "logs.txt"; //cesta
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
        if (File.Exists(logFilePath))
        {
            string lastLine = File.ReadLines(logFilePath).LastOrDefault(); // Naètení posledního øádku
            if (!string.IsNullOrEmpty(lastLine))
            {
                txtCoinName.Text = lastLine; 
            }
        }
        else
        {
            File.Create(logFilePath).Close(); // Vytvoøí souboru
        }
    }

    private void Savebtn_Click(object sender, EventArgs e)
    {
        
        string searchQuery = txtCoinName.Text;
        if (!string.IsNullOrEmpty(searchQuery))
        {
            MessageBox.Show("Uloženo!");
            File.AppendAllText(logFilePath, searchQuery + Environment.NewLine); // Uložení
        }

    }
}
