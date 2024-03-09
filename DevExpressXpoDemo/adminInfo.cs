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
    public partial class adminInfo : Form
    {
        public UnitOfWork Uow { get; set; }
        public int Id;
        public string AdminName;
        public string Password;
        public adminPage adminPage { get; set; }
        public adminInfo(adminPage adminPage)
        {
            InitializeComponent();
            this.adminPage = adminPage;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangeInfo(Id);
        }
        public void Connection()
        {
            try
            {
                Xdb.ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaOnly);
                Uow = new UnitOfWork(XpoDefault.DataLayer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
        }
        private void adminInfo_Load(object sender, EventArgs e)
        {
            Connection();
            txtId.Text = Id.ToString();
            txtAdminname.Text = AdminName;
            txtPassword.Text = Password;
        }
        public void ChangeInfo(int id)
        {
            var changed = Uow.GetObjectByKey<Admin>(id);
            changed.Password = txtPassword.Text;
            changed.Adminname = txtAdminname.Text;
            adminPage.AdminName = AdminName;
            adminPage.Password = txtPassword.Text;
            Uow.CommitChanges();
            MessageBox.Show("Yönetici bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
