using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApi
{
    internal class SaveData
    {
        public void Save(string logFilePath, TextBox coinNameText) 
        {
            string searchQuery = coinNameText.Text;
            if (!string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Uloženo!");
                File.AppendAllText(logFilePath, searchQuery + Environment.NewLine); 
            }
        }
    }
}
