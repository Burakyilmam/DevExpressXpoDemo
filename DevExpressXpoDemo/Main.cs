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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            userList userPage = new userList();
            userPage.MdiParent = this;
            userPage.Dock = DockStyle.Fill;
            userPage.WindowState = FormWindowState.Maximized;
            userPage.Show();
        }
    }
}
