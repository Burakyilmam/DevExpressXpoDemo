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
        public adminInfo()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangeInfo();
        }
        private void adminInfo_Load(object sender, EventArgs e)
        {
            txtId.Text = Sabitler.adminId.ToString();
            txtAdminname.Text = Sabitler.adminName;
            txtPassword.Text = Sabitler.adminPassword;
        }
        public void ChangeInfo()
        {
            var changed = Sabitler.uow.GetObjectByKey<Admin>(Sabitler.adminId);
            changed.Password = txtPassword.Text;
            Sabitler.adminPassword = changed.Password;
            changed.AdminName = txtAdminname.Text;
            Sabitler.adminName = changed.AdminName;
            Sabitler.uow.CommitChanges();
            MessageBox.Show("Yönetici bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
