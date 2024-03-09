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
    public partial class adminPage : Form
    {
        public int Id { get; set; }
        public string AdminName { get; set; }
        public string Password { get; set; }
        public adminPage()
        {
            InitializeComponent();
        }

        private void Logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            adminLogin adminLogin = new adminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void AdminInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            adminInfo adminInfo = new adminInfo();
            adminInfo.Id = Id;
            adminInfo.AdminName = AdminName;
            adminInfo.Password = Password;
            adminInfo.Show();
        }

        private void ChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            adminChangePassword adminChangePassword = new adminChangePassword();
            adminChangePassword.Show();
        }

        private void PdfViewer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            adminPdfViewer adminPdfViewer = new adminPdfViewer();
            adminPdfViewer.MdiParent = this;
            adminPdfViewer.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            adminPdfViewer.Show();
        }

        private void ExcelViewer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            adminExcel adminExcel = new adminExcel();
            adminExcel.MdiParent = this;
            adminExcel.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            adminExcel.Show();
        }

        private void TextEditor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            adminTextEditor adminTextEditor = new adminTextEditor();
            adminTextEditor.MdiParent = this;
            adminTextEditor.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            adminTextEditor.Show();
        }

        private void DocumentViewer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            adminDocument adminDocument = new adminDocument();
            adminDocument.MdiParent = this;
            adminDocument.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            adminDocument.Show();
        }
    }
}
