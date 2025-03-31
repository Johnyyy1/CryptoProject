using System;
using System.Windows.Forms;

namespace CryptoApi;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void btnGetInfo_Click(object sender, EventArgs e)
    {
        string coinName = txtCoinName.Text.ToLower(); 

        var apiHandler = new ApiHandler();
        Crypto? coin = await apiHandler.GetCrypto(coinName);

        if (coin != null)
        {
            if (!string.IsNullOrEmpty(coin.Image?.Large))
            {
                pictureBoxLogo.Load(coin.Image.Large); 
            }

            lblCoinInfo.Text = $"Název: {coin.Name} ({coin.Symbol.ToUpper()})\nCena (USD): {coin.Market_Data.Current_Price["usd"]}";
        }
        else
        {
            MessageBox.Show("Nepodaøilo se naèíst informace o kryptomìnì.");
        }
    }

}
