namespace YazilimMuhendisligiProje_ToDoList
{
    partial class QuickNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickNoteForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dövizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamamlandıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamaHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clbYapilacaklarListesi = new System.Windows.Forms.CheckedListBox();
            this.lblYapilacaklarListesi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpYeniGorev = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstTamamlananlarListesi = new System.Windows.Forms.ListBox();
            this.lblTamamlananlarListesi = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpYeniGorev.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.copyToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1548, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = global::YazilimMuhendisligiProje_ToDoList.Properties.Resources._1564491_add_create_new_plus_icon;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = global::YazilimMuhendisligiProje_ToDoList.Properties.Resources._1564503_add_business_edit_editor_new_icon__1_;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.openToolStripButton.Text = "&Open";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = global::YazilimMuhendisligiProje_ToDoList.Properties.Resources._1564505_close_delete_exit_remove_icon;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.helpToolStripButton.Text = "He&lp";
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
            this.menuStrip1.Size = new System.Drawing.Size(1548, 28);
            this.menuStrip1.TabIndex = 1;
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
            this.dövizToolStripMenuItem,
            this.düzeltToolStripMenuItem,
            this.silToolStripMenuItem,
            this.tamamlandıToolStripMenuItem,
            this.bigNoteToolStripMenuItem});
            this.toDToolStripMenuItem.Name = "toDToolStripMenuItem";
            this.toDToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.toDToolStripMenuItem.Text = "ToDo";
            // 
            // yeToolStripMenuItem
            // 
            this.yeToolStripMenuItem.Image = global::YazilimMuhendisligiProje_ToDoList.Properties.Resources._1564491_add_create_new_plus_icon;
            this.yeToolStripMenuItem.Name = "yeToolStripMenuItem";
            this.yeToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.yeToolStripMenuItem.Text = "Yeni";
            // 
            // dövizToolStripMenuItem
            // 
            this.dövizToolStripMenuItem.Name = "dövizToolStripMenuItem";
            this.dövizToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.dövizToolStripMenuItem.Text = "Döviz";
            this.dövizToolStripMenuItem.Click += new System.EventHandler(this.dövizToolStripMenuItem_Click);
            // 
            // düzeltToolStripMenuItem
            // 
            this.düzeltToolStripMenuItem.Image = global::YazilimMuhendisligiProje_ToDoList.Properties.Resources._1564503_add_business_edit_editor_new_icon__1_;
            this.düzeltToolStripMenuItem.Name = "düzeltToolStripMenuItem";
            this.düzeltToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.düzeltToolStripMenuItem.Text = "Düzelt";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = global::YazilimMuhendisligiProje_ToDoList.Properties.Resources._1564505_close_delete_exit_remove_icon;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // tamamlandıToolStripMenuItem
            // 
            this.tamamlandıToolStripMenuItem.Name = "tamamlandıToolStripMenuItem";
            this.tamamlandıToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.tamamlandıToolStripMenuItem.Text = "Tamamlandı";
            // 
            // bigNoteToolStripMenuItem
            // 
            this.bigNoteToolStripMenuItem.Name = "bigNoteToolStripMenuItem";
            this.bigNoteToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.bigNoteToolStripMenuItem.Text = "BigNote";
            this.bigNoteToolStripMenuItem.Click += new System.EventHandler(this.bigNoteToolStripMenuItem_Click);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clbYapilacaklarListesi);
            this.splitContainer1.Panel1.Controls.Add(this.lblYapilacaklarListesi);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.grpYeniGorev);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstTamamlananlarListesi);
            this.splitContainer1.Panel2.Controls.Add(this.lblTamamlananlarListesi);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.splitContainer1.Size = new System.Drawing.Size(1548, 955);
            this.splitContainer1.SplitterDistance = 740;
            this.splitContainer1.SplitterWidth = 12;
            this.splitContainer1.TabIndex = 2;
            // 
            // clbYapilacaklarListesi
            // 
            this.clbYapilacaklarListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbYapilacaklarListesi.FormattingEnabled = true;
            this.clbYapilacaklarListesi.Location = new System.Drawing.Point(16, 300);
            this.clbYapilacaklarListesi.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.clbYapilacaklarListesi.Name = "clbYapilacaklarListesi";
            this.clbYapilacaklarListesi.Size = new System.Drawing.Size(708, 644);
            this.clbYapilacaklarListesi.TabIndex = 6;
            this.clbYapilacaklarListesi.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lblYapilacaklarListesi
            // 
            this.lblYapilacaklarListesi.AutoSize = true;
            this.lblYapilacaklarListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYapilacaklarListesi.Location = new System.Drawing.Point(16, 262);
            this.lblYapilacaklarListesi.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblYapilacaklarListesi.Name = "lblYapilacaklarListesi";
            this.lblYapilacaklarListesi.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.lblYapilacaklarListesi.Size = new System.Drawing.Size(156, 38);
            this.lblYapilacaklarListesi.TabIndex = 5;
            this.lblYapilacaklarListesi.Text = "Yapılacaklar Listesi";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(16, 240);
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 22);
            this.panel1.TabIndex = 4;
            // 
            // grpYeniGorev
            // 
            this.grpYeniGorev.Controls.Add(this.textBox1);
            this.grpYeniGorev.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpYeniGorev.Location = new System.Drawing.Point(16, 11);
            this.grpYeniGorev.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.grpYeniGorev.Name = "grpYeniGorev";
            this.grpYeniGorev.Padding = new System.Windows.Forms.Padding(31, 22, 31, 22);
            this.grpYeniGorev.Size = new System.Drawing.Size(708, 229);
            this.grpYeniGorev.TabIndex = 3;
            this.grpYeniGorev.TabStop = false;
            this.grpYeniGorev.Text = "Yeni Görev";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(31, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(646, 170);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstTamamlananlarListesi
            // 
            this.lstTamamlananlarListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTamamlananlarListesi.FormattingEnabled = true;
            this.lstTamamlananlarListesi.ItemHeight = 16;
            this.lstTamamlananlarListesi.Location = new System.Drawing.Point(16, 49);
            this.lstTamamlananlarListesi.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.lstTamamlananlarListesi.Name = "lstTamamlananlarListesi";
            this.lstTamamlananlarListesi.Size = new System.Drawing.Size(764, 895);
            this.lstTamamlananlarListesi.TabIndex = 3;
            // 
            // lblTamamlananlarListesi
            // 
            this.lblTamamlananlarListesi.AutoSize = true;
            this.lblTamamlananlarListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTamamlananlarListesi.Location = new System.Drawing.Point(16, 11);
            this.lblTamamlananlarListesi.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblTamamlananlarListesi.Name = "lblTamamlananlarListesi";
            this.lblTamamlananlarListesi.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.lblTamamlananlarListesi.Size = new System.Drawing.Size(175, 38);
            this.lblTamamlananlarListesi.TabIndex = 6;
            this.lblTamamlananlarListesi.Text = "Tamamlananlar Listesi";
            // 
            // QuickNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 1010);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "QuickNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpYeniGorev.ResumeLayout(false);
            this.grpYeniGorev.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzeltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamaHakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamamlandıToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpYeniGorev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox clbYapilacaklarListesi;
        private System.Windows.Forms.Label lblYapilacaklarListesi;
        private System.Windows.Forms.ListBox lstTamamlananlarListesi;
        private System.Windows.Forms.Label lblTamamlananlarListesi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem dövizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigNoteToolStripMenuItem;
    }
}