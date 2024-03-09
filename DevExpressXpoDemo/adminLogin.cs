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
        public UnitOfWork uow { get; set; }
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
            Connection();
            txtPassword.Properties.UseSystemPasswordChar = true;
        }
        public void Connection()
        {
            Xdb.ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaOnly);
            uow = new UnitOfWork(XpoDefault.DataLayer);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string adminname = txtUsername.Text;
                string password = txtPassword.Text;
                var login = uow.Query<Admin>().FirstOrDefault(x => x.Adminname == adminname && x.Password == password);
                if (login != null)
                {
                    adminPage adminPage = new adminPage();
                    adminPage.AdminName = adminname;
                    adminPage.Password = password;
                    adminPage.Id = login.Id;
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
