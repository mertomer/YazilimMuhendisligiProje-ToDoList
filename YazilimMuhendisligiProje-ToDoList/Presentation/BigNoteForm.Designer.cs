namespace YazilimMuhendisligiProje_ToDoList.Presentation
{
    partial class BigNoteForm
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
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.button36 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.gtrTxt = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finansİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamaHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickNoteFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(167, 378);
            this.txtBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(280, 125);
            this.txtBox1.TabIndex = 77;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(231, 556);
            this.button36.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(155, 28);
            this.button36.TabIndex = 78;
            this.button36.Text = "Ekle";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(499, 160);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 332);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "AY-YIL";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(167, 160);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 81;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // gtrTxt
            // 
            this.gtrTxt.Location = new System.Drawing.Point(730, 518);
            this.gtrTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gtrTxt.Name = "gtrTxt";
            this.gtrTxt.Size = new System.Drawing.Size(105, 30);
            this.gtrTxt.TabIndex = 82;
            this.gtrTxt.Text = "Getir";
            this.gtrTxt.UseVisualStyleBackColor = true;
            this.gtrTxt.Click += new System.EventHandler(this.gtrTxt_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 518);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 83;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.toDToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 28);
            this.menuStrip1.TabIndex = 84;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // toDToolStripMenuItem
            // 
            this.toDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeToolStripMenuItem,
            this.bigNoteToolStripMenuItem,
            this.finansİşlemleriToolStripMenuItem,
            this.quickNoteFormToolStripMenuItem});
            this.toDToolStripMenuItem.Name = "toDToolStripMenuItem";
            this.toDToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.toDToolStripMenuItem.Text = "ToDo";
            // 
            // yeToolStripMenuItem
            // 
            this.yeToolStripMenuItem.Image = global::YazilimMuhendisligiProje_ToDoList.Properties.Resources._1564491_add_create_new_plus_icon;
            this.yeToolStripMenuItem.Name = "yeToolStripMenuItem";
            this.yeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yeToolStripMenuItem.Text = "Yeni";
            // 
            // bigNoteToolStripMenuItem
            // 
            this.bigNoteToolStripMenuItem.Name = "bigNoteToolStripMenuItem";
            this.bigNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bigNoteToolStripMenuItem.Text = "Coin Form";
            this.bigNoteToolStripMenuItem.Click += new System.EventHandler(this.bigNoteToolStripMenuItem_Click);
            // 
            // finansİşlemleriToolStripMenuItem
            // 
            this.finansİşlemleriToolStripMenuItem.Name = "finansİşlemleriToolStripMenuItem";
            this.finansİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.finansİşlemleriToolStripMenuItem.Text = "Finans İşlemleri";
            this.finansİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.finansİşlemleriToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uygulamaHakkındaToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // uygulamaHakkındaToolStripMenuItem
            // 
            this.uygulamaHakkındaToolStripMenuItem.Name = "uygulamaHakkındaToolStripMenuItem";
            this.uygulamaHakkındaToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.uygulamaHakkındaToolStripMenuItem.Text = "Uygulama Hakkında";
            this.uygulamaHakkındaToolStripMenuItem.Click += new System.EventHandler(this.uygulamaHakkındaToolStripMenuItem_Click);
            // 
            // quickNoteFormToolStripMenuItem
            // 
            this.quickNoteFormToolStripMenuItem.Name = "quickNoteFormToolStripMenuItem";
            this.quickNoteFormToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quickNoteFormToolStripMenuItem.Text = "Quick Note Form";
            this.quickNoteFormToolStripMenuItem.Click += new System.EventHandler(this.quickNoteFormToolStripMenuItem_Click);
            // 
            // BigNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YazilimMuhendisligiProje_ToDoList.Properties.Resources.desktop_wallpaper_30_cool_plain_backgrounds_plain_but_nice_backgrounds;
            this.ClientSize = new System.Drawing.Size(1229, 709);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gtrTxt);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BigNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button gtrTxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finansİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickNoteFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamaHakkındaToolStripMenuItem;
    }
}