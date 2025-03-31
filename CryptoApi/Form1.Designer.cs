using System;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

namespace CryptoApi
{
    public partial class Form1 : Form
    {

        private void InitializeComponent()
        {
            txtCoinName = new TextBox();
            btnGetInfo = new Button();
            pictureBoxLogo = new PictureBox();
            lblCoinInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // txtCoinName
            // 
            txtCoinName.Location = new Point(20, 20);
            txtCoinName.Name = "txtCoinName";
            txtCoinName.Size = new Size(200, 27);
            txtCoinName.TabIndex = 0;
            txtCoinName.Text = "bitcoin";
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(230, 20);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(75, 27);
            btnGetInfo.TabIndex = 1;
            btnGetInfo.Text = "Získat Info";
            btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(20, 60);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(100, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // lblCoinInfo
            // 
            lblCoinInfo.Location = new Point(130, 60);
            lblCoinInfo.Name = "lblCoinInfo";
            lblCoinInfo.Size = new Size(300, 100);
            lblCoinInfo.TabIndex = 3;
            // 
            // Form1
            // 
            ClientSize = new Size(450, 200);
            Controls.Add(txtCoinName);
            Controls.Add(btnGetInfo);
            Controls.Add(pictureBoxLogo);
            Controls.Add(lblCoinInfo);
            Name = "Form1";
            Text = "CoinGecko API - Crypto Info";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox txtCoinName;
        private System.Windows.Forms.Label lblCoinInfo;
    }
}

