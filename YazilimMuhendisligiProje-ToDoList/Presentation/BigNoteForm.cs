using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMuhendisligiProje_ToDoList.Presentation
{
    public partial class BigNoteForm : Form
   
    
    {
        string saat;
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public int userId;
        public BigNoteForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;


        }

        

        void kullanicigetir()
     {
            string selectedDate = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");

            using (baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=db_YapilacaklarListesi23;Integrated Security=True;"))
            {
                da = new SqlDataAdapter("SELECT * FROM TBLBIGNOTE1 WHERE CONVERT(date, NoteDate) = @selectedDate AND [User] = @userId", baglanti);
                da.SelectCommand.Parameters.AddWithValue("@selectedDate", selectedDate);
                da.SelectCommand.Parameters.AddWithValue("@userId", userId);

                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedTime = dateTimePicker1.Value;
            saat = selectedTime.ToString("HH:mm");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedDate = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            kullanicigetir();
            DateTime selectedDate = e.Start;
            string selectedMonth = selectedDate.ToString("MMMM");
            int selectedYear = selectedDate.Year;
            label8.Text = selectedMonth + " " + selectedYear.ToString();

        }
       

        
        private void button36_Click(object sender, EventArgs e)
        {
            string selectedDate = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string fullDateTime = selectedDate + " " + saat + ":00";

            if (!DateTime.TryParse(fullDateTime, out DateTime noteDateTime))
            {
                MessageBox.Show("Geçersiz tarih ve saat formatı: " + fullDateTime, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string task = txtBox1.Text;

            string sorgu = "INSERT INTO TBLBIGNOTE1([User], BigNote, NoteDate, NoteTime, NoteDateAndTime) VALUES(@user, @task, @noteDate, @noteTime, @noteDateAndTime)";
            using (baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=db_YapilacaklarListesi23;Integrated Security=True;"))
            {
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@user", userId);
                komut.Parameters.AddWithValue("@task", task);
                komut.Parameters.AddWithValue("@noteDate", selectedDate);
                komut.Parameters.AddWithValue("@noteTime", saat);
                komut.Parameters.AddWithValue("@noteDateAndTime", fullDateTime); // Tarih ve saat birleşimi

                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Not başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                    kullanicigetir();
                }
            }
        }
    private void gtrTxt_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            kullanicigetir();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.ShowUpDown = true;
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime selectedTime = dateTimePicker1.Value;
            saat = selectedTime.ToString("HH:mm");
        }

            private void txtBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void bigNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CoinForm(userId).Show();
            this.Hide();
        }

        private void finansİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmFinance(userId).Show();
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
