using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpressXpoDemo
{
    public partial class Opening : DevExpress.XtraEditors.XtraForm
    {
        public Opening()
        {
            InitializeComponent();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            userLogin user = new userLogin();
            user.Show();
            this.Hide();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            adminLogin admin = new adminLogin();
            admin.Show();
            this.Hide();
        }

        private void Opening_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
