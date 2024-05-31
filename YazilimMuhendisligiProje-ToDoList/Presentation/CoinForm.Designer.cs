namespace YazilimMuhendisligiProje_ToDoList.Presentation
{
    partial class CoinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCoinMarketCap = new System.Windows.Forms.Label();
            this.lblCoinVolume = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCoinPrice = new System.Windows.Forms.Label();
            this.cmbCoin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCoinMarketCap
            // 
            this.lblCoinMarketCap.AutoSize = true;
            this.lblCoinMarketCap.Location = new System.Drawing.Point(505, 177);
            this.lblCoinMarketCap.Name = "lblCoinMarketCap";
            this.lblCoinMarketCap.Size = new System.Drawing.Size(65, 13);
            this.lblCoinMarketCap.TabIndex = 13;
            this.lblCoinMarketCap.Text = "Market Cap:";
            this.lblCoinMarketCap.Click += new System.EventHandler(this.lblCoinMarketCap_Click);
            // 
            // lblCoinVolume
            // 
            this.lblCoinVolume.AutoSize = true;
            this.lblCoinVolume.Location = new System.Drawing.Point(505, 149);
            this.lblCoinVolume.Name = "lblCoinVolume";
            this.lblCoinVolume.Size = new System.Drawing.Size(69, 13);
            this.lblCoinVolume.TabIndex = 12;
            this.lblCoinVolume.Text = "Coin Volume:";
            this.lblCoinVolume.Click += new System.EventHandler(this.lblCoinVolume_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hedef Değer :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(257, 213);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblCoinPrice
            // 
            this.lblCoinPrice.AutoSize = true;
            this.lblCoinPrice.Location = new System.Drawing.Point(505, 204);
            this.lblCoinPrice.Name = "lblCoinPrice";
            this.lblCoinPrice.Size = new System.Drawing.Size(37, 13);
            this.lblCoinPrice.TabIndex = 14;
            this.lblCoinPrice.Text = "Price: ";
            this.lblCoinPrice.Click += new System.EventHandler(this.lblCoinPrice_Click);
            // 
            // cmbCoin
            // 
            this.cmbCoin.FormattingEnabled = true;
            this.cmbCoin.Location = new System.Drawing.Point(257, 149);
            this.cmbCoin.Name = "cmbCoin";
            this.cmbCoin.Size = new System.Drawing.Size(121, 21);
            this.cmbCoin.TabIndex = 15;
            this.cmbCoin.SelectedIndexChanged += new System.EventHandler(this.cmbCoin_SelectedIndexChanged_1);
            // 
            // CoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCoin);
            this.Controls.Add(this.lblCoinPrice);
            this.Controls.Add(this.lblCoinMarketCap);
            this.Controls.Add(this.lblCoinVolume);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Name = "CoinForm";
            this.Text = "CoinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoinMarketCap;
        private System.Windows.Forms.Label lblCoinVolume;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCoinPrice;
        private System.Windows.Forms.ComboBox cmbCoin;
    }
}