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
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void adminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Opening opening = new Opening();
            opening.Show();
            this.Hide();
        }

        private void adminLogin_Load(object sender, EventArgs e)
        {
            txtPassword.Properties.UseSystemPasswordChar = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string adminname = txtUsername.Text;
                string password = txtPassword.Text;
                var login = Sabitler.uow.Query<Admin>().FirstOrDefault(x => x.AdminName == adminname && x.Password == password && x.Status == true);
                if (login != null)
                {
                    adminPage adminPage = new adminPage();
                    Sabitler.adminName = adminname;
                    Sabitler.adminPassword = password;
                    Sabitler.adminId = login.Id;
                    Sabitler.IsAdmin = true;
                    Sabitler.SessionAdmin();
                    adminPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yönetici adı veya parola hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
