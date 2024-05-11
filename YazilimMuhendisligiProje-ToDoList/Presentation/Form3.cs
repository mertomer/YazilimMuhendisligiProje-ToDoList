using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazilimMuhendisligiProje_ToDoList.Presentation
{
    public partial class Form3 : Form
    {
        static string constring = "Data Source=LAPTOP-DR0CC8RT\\SQLEXPRESS;Initial Catalog=tasks;Integrated Security=True;Trust Server Certificate=True";
        private SqlConnection connect = new SqlConnection();
        public Form3()
        {
            InitializeComponent();
         
            button36.Click += button36_Click;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
         //Değşken selected date de saklanıyor. buna sql bağlayacağız şimdi.

           
            string selectedMonth = selectedDate.ToString("MMMM"); // Ay ismini alır
            int selectedYear = selectedDate.Year; // Yıl bilgisini alır

            // Label kontrolüne ay ve yıl bilgisini yazdır
            label8.Text = selectedMonth + " " + selectedYear.ToString();
         
        }
       

        private void button36_Click(object sender, EventArgs e)
        {
            string selectedDate = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string work = textBox1.Text;


            //-----------------------------------------

            try
            {
                if (connect.State== ConnectionState.Closed)
                
                    connect.Open();
                string kayit = "insert into Tasks(Tarih,Task) values @Tarih,@Task";
                SqlCommand komut = new SqlCommand(kayit, connect);
                komut.Parameters.AddWithValue("@Tarih", selectedDate);
                komut.Parameters.AddWithValue("@Task", textBox1);

                komut.ExecuteNonQuery();

                connect.Close();

                MessageBox.Show("Kayıt eklendi");
            }
            catch (Exception hata) {
            MessageBox.Show("Hata Meydana geldi. "+hata );
            }


        }

        private void gtrTxt_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
