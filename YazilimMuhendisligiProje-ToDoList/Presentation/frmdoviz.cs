using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace YazilimMuhendisligiProje_ToDoList.Presentation
{
    public partial class frmdoviz : Form
    {
        public frmdoviz()
        {
            InitializeComponent();
        }
        public string dolarAlis;
        public string dolarSatis;
        public string euroAlis;
        public string euroSatis;

        private void doviz_Load(object sender, EventArgs e)
        {
            String bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);
            
            dolarAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            dolarAlisText.Text = dolarAlis;

             dolarSatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            dolarSatisText.Text = dolarSatis;

             euroAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            euroAlisText.Text = euroAlis;

             euroSatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            euroSatisText.Text = euroSatis;

        }

        private void dolarAlis_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dolarSatisText_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void euroAlisText_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void euroSatisText_Click(object sender, EventArgs e)
        {

        }
    }
}
