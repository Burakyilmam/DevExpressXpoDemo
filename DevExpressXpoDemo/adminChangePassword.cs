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
        public UnitOfWork Uow { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }
        public adminPage adminPage { get; set; }
        public adminChangePassword(adminPage adminPage)
        {
            InitializeComponent();
            this.adminPage = adminPage;
        }

        private void adminChangePassword_Load(object sender, EventArgs e)
        {
            Connection();
        }
        public void Connection()
        {
            Xdb.ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaOnly);
            Uow = new UnitOfWork(XpoDefault.DataLayer);
        }
        public void ChangePassword()
        {
            var changed = Uow.GetObjectByKey<Admin>(Id);
            changed.Password = txtNew.Text;
            adminPage.Password = changed.Password;
            Uow.CommitChanges();
            MessageBox.Show("Parola başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtOld.Text == Password)
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
