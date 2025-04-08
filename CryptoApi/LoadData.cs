using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApi
{
    internal class LoadData
    {

        public void Load(string logFilePath,  TextBox coinNameText)
        {
            if (File.Exists(logFilePath))
            {
                string lastLine = File.ReadLines(logFilePath).LastOrDefault(); // Načtení posledního řádku
                if (!string.IsNullOrEmpty(lastLine))
                {
                    coinNameText.Text = lastLine;
                }
            }
            else
            {
                File.Create(logFilePath).Close(); // Vytvoří souboru
            }
        }
    }
}
