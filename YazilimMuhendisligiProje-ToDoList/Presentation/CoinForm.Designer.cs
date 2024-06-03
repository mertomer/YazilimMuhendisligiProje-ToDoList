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
            this.lblCoinMarketCap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCoinMarketCap.Location = new System.Drawing.Point(525, 222);
            this.lblCoinMarketCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoinMarketCap.Name = "lblCoinMarketCap";
            this.lblCoinMarketCap.Size = new System.Drawing.Size(79, 16);
            this.lblCoinMarketCap.TabIndex = 13;
            this.lblCoinMarketCap.Text = "Market Cap:";
            this.lblCoinMarketCap.Click += new System.EventHandler(this.lblCoinMarketCap_Click);
            // 
            // lblCoinVolume
            // 
            this.lblCoinVolume.AutoSize = true;
            this.lblCoinVolume.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCoinVolume.Location = new System.Drawing.Point(525, 186);
            this.lblCoinVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoinVolume.Name = "lblCoinVolume";
            this.lblCoinVolume.Size = new System.Drawing.Size(86, 16);
            this.lblCoinVolume.TabIndex = 12;
            this.lblCoinVolume.Text = "Coin Volume:";
            this.lblCoinVolume.Click += new System.EventHandler(this.lblCoinVolume_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(553, 312);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(127, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hedef Değer :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Location = new System.Drawing.Point(298, 262);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblCoinPrice
            // 
            this.lblCoinPrice.AutoSize = true;
            this.lblCoinPrice.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCoinPrice.Location = new System.Drawing.Point(525, 249);
            this.lblCoinPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoinPrice.Name = "lblCoinPrice";
            this.lblCoinPrice.Size = new System.Drawing.Size(44, 16);
            this.lblCoinPrice.TabIndex = 14;
            this.lblCoinPrice.Text = "Price: ";
            this.lblCoinPrice.Click += new System.EventHandler(this.lblCoinPrice_Click);
            // 
            // cmbCoin
            // 
            this.cmbCoin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbCoin.FormattingEnabled = true;
            this.cmbCoin.Location = new System.Drawing.Point(298, 183);
            this.cmbCoin.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCoin.Name = "cmbCoin";
            this.cmbCoin.Size = new System.Drawing.Size(160, 24);
            this.cmbCoin.TabIndex = 15;
            this.cmbCoin.SelectedIndexChanged += new System.EventHandler(this.cmbCoin_SelectedIndexChanged_1);
            // 
            // CoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YazilimMuhendisligiProje_ToDoList.Properties.Resources._141112134420_bitcoin_graph;
            this.ClientSize = new System.Drawing.Size(728, 431);
            this.Controls.Add(this.cmbCoin);
            this.Controls.Add(this.lblCoinPrice);
            this.Controls.Add(this.lblCoinMarketCap);
            this.Controls.Add(this.lblCoinVolume);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.ForeColor = System.Drawing.Color.Coral;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CoinForm";
            this.Text = "CoinForm";
            this.Load += new System.EventHandler(this.CoinForm_Load_1);
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