using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;

namespace YazilimMuhendisligiProje_ToDoList.Presentation
{
    public partial class frmFinance : Form
    {
        public int userId;
        public string dolarAlis;
        public string dolarSatis;
        public string euroAlis;
        public string euroSatis;

        public frmFinance(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void doviz_Load()
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            dolarAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            dolarSatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            euroAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            euroSatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doviz_Load();

            List<string> dovizKurlari = new List<string> { "USD", "EUR" };
            cmbDoviz.Items.AddRange(dovizKurlari.ToArray());

            cmbDoviz.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenDoviz = cmbDoviz.SelectedItem.ToString();

            switch (secilenDoviz)
            {
                case "USD":
                    label2.Text = "Alış: " + dolarAlis;
                    label3.Text = "Satış: " + dolarSatis;
                    break;
                case "EUR":
                    label2.Text = "Alış: " + euroAlis;
                    label3.Text = "Satış: " + euroSatis;
                    break;
                default:
                    label2.Text = "Alış: Bilinmiyor";
                    label3.Text = "Satış: Bilinmiyor";
                    break;
            }
        }

        private void finansİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CoinForm(userId).Show();
            this.Hide();
        }

        private void bigNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BigNoteForm(userId).Show();
            this.Hide();
        }

        private void quickNoteFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QuickNoteForm(userId).Show();
            this.Hide();
        }

        private void uygulamaHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://son-deneme-web-site.vercel.app/",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("URL açılırken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
