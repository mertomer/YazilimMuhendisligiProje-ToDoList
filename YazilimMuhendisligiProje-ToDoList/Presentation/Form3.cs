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

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form3()
        {
            InitializeComponent();
         
           // button36.Click += button36_Click;

        }

        public int userId;
         void kullanicigetir()
     {
            string selectedDate = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");

            baglanti = new SqlConnection("Data Source=LAPTOP-DR0CC8RT\\SQLEXPRESS;Initial Catalog=db_YapilacaklarListesi23;Integrated Security=True;");
             
                 baglanti.Open();
        
            da =new SqlDataAdapter("SELECT * FROM TBLBIGNOTE WHERE NoteDate = '" + selectedDate + "'", baglanti);
                     DataTable tablo=new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource= tablo;
               baglanti.Close();
          
     }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedDate = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
              
         
           
             
           
              
                
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
         //Değşken selected date de saklanıyor. buna sql bağlayacağız şimdi.

           
            string selectedMonth = selectedDate.ToString("MMMM"); // Ay ismini alır
            int selectedYear = selectedDate.Year; // Yıl bilgisini alır

            // Label kontrolüne ay ve yıl bilgisini yazdır
            label8.Text = selectedMonth + " " + selectedYear.ToString();

            kullanicigetir();

         
        }
       

        private void button36_Click(object sender, EventArgs e)
        {
            string selectedDate = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string task = txtBox1.Text;
            int user;
            user = userId;
            frmLogin frmLogin = new frmLogin();
            string sorgu = "INSERT INTO TBLBIGNOTE([User],BigNote,NoteDate) VALUES(@user,@task,@selectedDate)";
            komut = new SqlCommand(sorgu, baglanti);

            
                             
            baglanti.Open();

            komut.Parameters.AddWithValue("@[User]", user);
            komut.Parameters.AddWithValue("@BigNote",task);
            komut.Parameters.AddWithValue("@NoteDate", selectedDate);
             
           
           komut.ExecuteNonQuery();
            baglanti.Close();

            kullanicigetir();




        }

        private void gtrTxt_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            kullanicigetir();
        }
    }
}
