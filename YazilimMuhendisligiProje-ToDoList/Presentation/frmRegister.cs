using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using YazilimMuhendisligiProje_ToDoList.Presentation;

namespace YazilimMuhendisligiProje_ToDoList
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsof.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve Şifre alanları boş bırakılamaz", "Kayıt işlemi başarısız",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else if (txtUsername.Text == txtComPassword.Text)
            {
                con.Open();
                String register = "INSERT INTO tbl_users Values('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                cmd= new OleDbCommand(register,con);
                cmd.ExecuteNonQuery();
                con.Close();
               
                
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
    }
}
