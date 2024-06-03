using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ServiceStack;
using Org.BouncyCastle.Bcpg;


namespace YazilimMuhendisligiProje_ToDoList.Presentation
{
    public partial class frmLogin : Form
    {
      public int UserWrite;
      
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection(@"Data Source=MERT\SQLEXPRESS;Initial Catalog=db_YapilacaklarListesi23;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string query = "SELECT * FROM TBLUSER WHERE username = @username AND password = @password";
            SqlCommand command = new SqlCommand(query, baglanti);
            command.Parameters.AddWithValue("@username", txtUsername.Text);
            command.Parameters.AddWithValue("@password", txtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();

       

            if (dr.Read()==true)
            {


                QuickNoteForm frm = new QuickNoteForm(dr.GetInt32(0));
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Şifre yada kullanıcı adı yanlış,Lütfen tekrar deneyiniz ", "giriş başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {

                txtPassword.PasswordChar = '\0';
                
            }
            else
            {
                txtPassword.PasswordChar = '*';
                

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=DESKTOP-3VHA91B\SQLEXPRESS;Initial Catalog=db_YapilacaklarListesi;Integrated Security=True;Trust Server Certificate=True
//Data Source=DESKTOP-3VHA91B\SQLEXPRESS;Initial Catalog=DBYAPILACAKLARLISTESI1;Integrated Security=True;"