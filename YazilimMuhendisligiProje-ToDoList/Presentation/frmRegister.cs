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
using YazilimMuhendisligiProje_ToDoList.Presentation;
using System.Collections;

namespace YazilimMuhendisligiProje_ToDoList
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3VHA91B\SQLEXPRESS;Initial Catalog=db_YapilacaklarListesi;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve Şifre alanları boş bırakılamaz", "Kayıt işlemi başarısız",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else if (txtPassword.Text == txtComPassword.Text)
            {
                baglanti.Open();
                string register = "INSERT INTO TBLUSER (username, password) VALUES (@username, @password)";
                SqlCommand command = new SqlCommand(register, baglanti);
                command.Parameters.AddWithValue("@username", txtUsername.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);
                command.ExecuteNonQuery();




                txtUsername.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";
                  
                MessageBox.Show("Hesabınız başarılı bir şekilde oluşturuldu","Kayıt Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
       else
            {
                MessageBox.Show("Şifreler uyuşmuyor, Tekrar deneyiniz.", "Giriş başarısız oldu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckbxShowPas.Checked) {

                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar= '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
