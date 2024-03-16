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
    public partial class adminChangePassword : Form
    {
        public adminChangePassword()
        {
            InitializeComponent();
        }

        private void adminChangePassword_Load(object sender, EventArgs e)
        {

        }
        public void ChangePassword()
        {
            var changed = Sabitler.uow.GetObjectByKey<Admin>(Sabitler.adminId);
            changed.Password = txtNew.Text;
            Sabitler.adminPassword = changed.Password;
            Sabitler.uow.CommitChanges();
            MessageBox.Show("Parola başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtOld.Text == Sabitler.adminPassword)
            {
                if (txtOld.Text == txtNew.Text)
                {
                    MessageBox.Show("Yeni parola ile eski parola aynı olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtNew.Text == txtNewControl.Text)
                    {
                        ChangePassword();
                    }
                    else
                    {
                        MessageBox.Show("Yeni parola ile yeni parola tekrar uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Eski parola hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
