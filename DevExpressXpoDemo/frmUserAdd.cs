using DevExpress.XtraRichEdit.Model;
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
    public partial class frmUserAdd : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public userList userList { get; set; }
        public frmUserAdd(userList userList)
        {
            InitializeComponent();
            this.userList = userList;
        }

        private void frmUserAdd_Load(object sender, EventArgs e)
        {
            txtPassword.Properties.UseSystemPasswordChar = true;
            userList.Connection();
        }
        public void Add()
        {
            User user = new User(userList.uow);
            user.Password = txtPassword.Text;
            user.Username = txtUsername.Text;
            userList.uow.CommitChanges();
            MessageBox.Show("Kullanıcı başarıyla eklendi","Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            userList.GetAll();
        }
    }
}
