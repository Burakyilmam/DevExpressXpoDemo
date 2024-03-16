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
    public partial class frmUserUpdate : Form
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public userList userList { get; set; }
        public frmUserUpdate(userList userList)
        {
            InitializeComponent();
            this.userList = userList;
        }

        private void frmUserUpdate_Load(object sender, EventArgs e)
        {
            txtPassword.Properties.UseSystemPasswordChar = true;
            txtUsername.Text = Username;
            txtPassword.Text = Password;
            txtId.Text = Id.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtId.Text);
            Update(id);
            userList.GetAll();
        }

        public void Update(int Id)
        {
            var updated = Sabitler.uow.GetObjectByKey<User>(Id);
            updated.Username = txtUsername.Text;
            updated.Password = txtPassword.Text;
            Sabitler.uow.CommitChanges();
            MessageBox.Show("Kullanıcı başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

        }
    }
}
