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
            Savebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // txtCoinName
            // 
            txtCoinName.Location = new Point(20, 20);
            txtCoinName.Name = "txtCoinName";
            txtCoinName.Size = new Size(200, 27);
            txtCoinName.TabIndex = 0;
            // 
            // btnGetInfo
            // 
            btnGetInfo.BackColor = SystemColors.Highlight;
            btnGetInfo.ForeColor = SystemColors.ActiveCaptionText;
            btnGetInfo.Location = new Point(230, 20);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(75, 27);
            btnGetInfo.TabIndex = 1;
            btnGetInfo.Text = "Získat Info";
            btnGetInfo.UseVisualStyleBackColor = false;
            btnGetInfo.Click += btnGetInfo_Click;
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
            lblCoinInfo.Font = new Font("Segoe UI", 12F);
            lblCoinInfo.ForeColor = Color.Red;
            lblCoinInfo.Location = new Point(130, 60);
            lblCoinInfo.Name = "lblCoinInfo";
            lblCoinInfo.Size = new Size(302, 100);
            lblCoinInfo.TabIndex = 3;
            // 
            // Savebtn
            // 
            Savebtn.BackColor = Color.ForestGreen;
            Savebtn.ForeColor = SystemColors.ActiveCaptionText;
            Savebtn.Location = new Point(321, 21);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(73, 26);
            Savebtn.TabIndex = 4;
            Savebtn.Text = "Uložit";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            // 
            // Form1
            // 
            BackColor = Color.Navy;
            ClientSize = new Size(443, 202);
            Controls.Add(Savebtn);
            Controls.Add(txtCoinName);
            Controls.Add(btnGetInfo);
            Controls.Add(pictureBoxLogo);
            Controls.Add(lblCoinInfo);
            Name = "Form1";
            Text = "CryptoApi";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox txtCoinName;
        private System.Windows.Forms.Label lblCoinInfo;
        private Button Savebtn;
    }
}

