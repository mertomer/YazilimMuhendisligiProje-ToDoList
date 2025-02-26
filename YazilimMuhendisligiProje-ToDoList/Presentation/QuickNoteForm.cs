﻿using Org.BouncyCastle.Asn1.Cmp;
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
using YazilimMuhendisligiProje_ToDoList.Presentation;

namespace YazilimMuhendisligiProje_ToDoList
{
    public partial class QuickNoteForm : Form
    {
        public int userId;

        public QuickNoteForm(int userId)
        {
            InitializeComponent();
            this.Load += QuickNoteForm_Load;
            this.userId = userId;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MERT\SQLEXPRESS;Initial Catalog=db_YapilacaklarListesi23;Integrated Security=True;");
        private void QuickNoteForm_Load(object sender, EventArgs e)
        {
            List<string> kullaniciNotlari = NotlariCek(userId);
            foreach (string not in kullaniciNotlari)
            {
                clbYapilacaklarListesi.Items.Add(not);
            }
        }

       
        private List<string> NotlariCek(int userId)
        {
            List<string> notlar = new List<string>();
          
            string sqlQuery = "SELECT QuickNote,NoteDate FROM TBLQUICKNOTE WHERE [User] = @UserId";
            
            
                using (SqlCommand command = new SqlCommand(sqlQuery, baglanti))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                    string not = $"{reader.GetString(0)} - {reader.GetDateTime(1)}";
                    notlar.Add(not);
                    }
                    baglanti.Close();
                }
            
            return notlar;
        }
       
       

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
                clbYapilacaklarListesi.Items.Add(textBox1.Text+" - "+noteDate);
                using (SqlCommand command = new SqlCommand(sqlQuery, baglanti))
                {
                    
                    command.Parameters.AddWithValue("@UserID", user);
                    command.Parameters.AddWithValue("@NoteContent", textBox1.Text);
                    command.Parameters.AddWithValue("@NoteDate", noteDate);

                    
                    baglanti.Open();
                    command.ExecuteNonQuery();

                    
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

       

        private void bigNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BigNoteForm(userId).Show();
            this.Hide();
        }

        private void finansİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmFinance(userId).Show();
            this.Hide();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CoinForm(userId).Show();
            this.Hide();
        }
    }
}
//HUAWEI=Data Source=MERT\SQLEXPRESS;Initial Catalog=db_YapilacaklarListesi23;Integrated Security=True;