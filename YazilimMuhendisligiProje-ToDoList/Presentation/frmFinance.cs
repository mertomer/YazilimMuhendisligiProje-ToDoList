using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace YazilimMuhendisligiProje_ToDoList.Presentation
{
    public partial class frmFinance : Form
    {
        public frmFinance()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);

        }
        public string dolarAlis;
        public string dolarSatis;
        public string euroAlis;
        public string euroSatis;

       

        private void doviz_Load()
        {
            String bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
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
    }
}
