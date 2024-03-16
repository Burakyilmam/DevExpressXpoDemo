using DevExpress.Xpo;
using DevExpressXpoDemo.Xdb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressXpoDemo
{
    public partial class userLogin : Form
    {
        public userLogin()
        {
            InitializeComponent();
        }
        private void userLogin_Load(object sender, EventArgs e)
        {
            txtPassword.Properties.UseSystemPasswordChar = true;
        }
        private void userLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Opening opening = new Opening();
            opening.Show();
            this.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                var login = Sabitler.uow.Query<User>().FirstOrDefault(x => x.Username == username && x.Password == password && x.Status == true);
                if (login != null)
                {
                    Main main = new Main();
                    Sabitler.userName = username;
                    Sabitler.userPassword = password;
                    Sabitler.userId = login.Id;
                    Sabitler.IsAdmin = false;
                    Sabitler.SessionUser();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya parola hatalı","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Hata : "+ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            txtPassword.Properties.UseSystemPasswordChar = false;
            btnEye.Visible = false;
            btnEyeClose.Visible = true;
        }

        private void btnEyeClose_Click(object sender, EventArgs e)
        {
            txtPassword.Properties.UseSystemPasswordChar = true;
            btnEye.Visible = true;
            btnEyeClose.Visible = false;
        }
    }
}
