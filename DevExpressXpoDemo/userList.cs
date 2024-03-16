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
    public partial class userList : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public userList()
        {
            InitializeComponent();
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            GetAll();
        }
        public void GetAll()
        {
            var users = Sabitler.uow.Query<User>().ToList();
            gridUser.DataSource = users;
        }
        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if(e.RowHandle >= 0)
            {
                if (gridView1.IsRowSelected(e.RowHandle))
                {
                    e.Appearance.ForeColor = Color.OrangeRed;
                    e.Appearance.BackColor = Color.Black;
                    FontStyle fs = e.Appearance.Font.Style;
                    fs = FontStyle.Bold;
                    e.Appearance.Font = new Font(e.Appearance.Font, fs);
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                User user = (User)gridView1.GetRow(e.FocusedRowHandle);
                txtId.EditValue = user.Id;
                txtPassword.EditValue = user.Password;
                txtUsername.EditValue = user.Username;
                Username = txtUsername.Text;
                Password = txtPassword.Text;
                Id = Convert.ToInt32(txtId.EditValue);
            }
        }
        public void DeleteUser()
        {
            try
            {
                int[] selectedRows = gridView1.GetSelectedRows();
                gridView1.BeginUpdate();
                foreach (int row in selectedRows)
                {
                    int id = (int)gridView1.GetRowCellValue(row, colId);
                    var deleted = Sabitler.uow.GetLoadedObjectByKey<User>(id);
                    Sabitler.uow.Delete(deleted);
                }
                gridUser.DataSource = null;
                gridView1.EndUpdate();
                Sabitler.uow.CommitChanges();
                MessageBox.Show("Kullanıcı silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void userDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if(gridView1.RowCount >= 1)
                {
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DeleteUser();
                        GetAll();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }
        public void DeleteAllUser()
        {
            gridUser.DataSource = null;
            var deleted = Sabitler.uow.Query<User>().ToList();
            Sabitler.uow.Delete(deleted);
            Sabitler.uow.CommitChanges();
            MessageBox.Show("Kullanıcı hepsi başarıyla silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Kullanıcıların hepsini silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteAllUser();
                    GetAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Deneme | *.xls",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = "Deneme.xls"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                gridUser.ExportToXls(saveFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Deneme | *.pdf",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = "Deneme.pdf"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                gridUser.ExportToPdf(saveFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HTML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Deneme | *.html",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = "Deneme.html"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                gridUser.ExportToHtml(saveFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!gridUser.IsPrintingAvailable)
            {
                MessageBox.Show("Yazdırma işlemi gerçekleşemiyor");
            }
            else
            {
                gridUser.ShowPrintPreview();
            }
        }

        private void userAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUserAdd frmuserAdd = new frmUserAdd(this);
            frmuserAdd.Id = Id;
            frmuserAdd.Username = Username;
            frmuserAdd.Password = Password;
            frmuserAdd.Show();
        }

        private void userUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUserUpdate frmUserUpdate = new frmUserUpdate(this);
            frmUserUpdate.Id = Id;
            frmUserUpdate.Username = Username;
            frmUserUpdate.Password = Password;
            frmUserUpdate.Show();
        }


    }
}
