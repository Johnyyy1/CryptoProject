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
        if (File.Exists(logFilePath))
        {
            string lastLine = File.ReadLines(logFilePath).LastOrDefault(); // Na�ten� posledn�ho ��dku
            if (!string.IsNullOrEmpty(lastLine))
            {
                txtCoinName.Text = lastLine; 
            }
        }
        else
        {
            File.Create(logFilePath).Close(); // Vytvo�� souboru
        }
    }

    private void Savebtn_Click(object sender, EventArgs e)
    {
        
        string searchQuery = txtCoinName.Text;
        if (!string.IsNullOrEmpty(searchQuery))
        {
            MessageBox.Show("Ulo�eno!");
            File.AppendAllText(logFilePath, searchQuery + Environment.NewLine); // Ulo�en�
        }

    }
}
