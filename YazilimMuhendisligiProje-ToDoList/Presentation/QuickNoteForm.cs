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

namespace YazilimMuhendisligiProje_ToDoList
{
    public partial class QuickNoteForm : Form
    {
       
        public QuickNoteForm()
        {
            InitializeComponent();
          
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3VHA91B\SQLEXPRESS;Initial Catalog=DBYAPILACAKLARLISTESI1;Integrated Security=True;");
        public int userId;

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void uygulamaHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
    {
                MessageBox.Show("Lütfen bir not giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int user = userId;
                string sqlQuery = "INSERT INTO TBLQUICKNOTE ([User], QuickNote, NoteDate) VALUES (@UserId, @NoteContent, @NoteDate)";
                DateTime noteDate = DateTime.Now;
                clbYapilacaklarListesi.Items.Add(textBox1.Text);
                using (SqlCommand command = new SqlCommand(sqlQuery, baglanti))
                {
                    // Parametrelerin tanımlanması ve değerlerin atanması
                    command.Parameters.AddWithValue("@UserID", user);
                    command.Parameters.AddWithValue("@NoteContent", textBox1.Text);
                    command.Parameters.AddWithValue("@NoteDate", noteDate);

                    // Bağlantı açılır ve komut çalıştırılır
                    baglanti.Open();
                    command.ExecuteNonQuery();

                    // Not eklendiğine dair bir mesaj göster
                    MessageBox.Show("Not başarıyla eklendi.");
                    baglanti.Close();
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
           

            String value =textBox1.Text;
            clbYapilacaklarListesi.Items.Add(value+" "+now); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
