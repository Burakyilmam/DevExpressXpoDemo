namespace DevExpressXpoDemo
{
    partial class userList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userList));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.userAdd = new DevExpress.XtraBars.BarButtonItem();
            this.userUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.userDelete = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteAll = new DevExpress.XtraBars.BarButtonItem();
            this.Excel = new DevExpress.XtraBars.BarButtonItem();
            this.PDF = new DevExpress.XtraBars.BarButtonItem();
            this.HTML = new DevExpress.XtraBars.BarButtonItem();
            this.Print = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridUser = new DevExpress.XtraGrid.GridControl();
            this.userXPBindingSource = new DevExpress.Xpo.XPBindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userXPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.userAdd,
            this.userUpdate,
            this.userDelete,
            this.DeleteAll,
            this.Excel,
            this.PDF,
            this.HTML,
            this.Print});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1178, 183);
            // 
            // userAdd
            // 
            this.userAdd.Caption = "Kullanıcı Ekle";
            this.userAdd.Id = 1;
            this.userAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("userAdd.ImageOptions.Image")));
            this.userAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("userAdd.ImageOptions.LargeImage")));
            this.userAdd.Name = "userAdd";
            this.userAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.userAdd_ItemClick);
            // 
            // userUpdate
            // 
            this.userUpdate.Caption = "Kullanıcı Güncelle";
            this.userUpdate.Id = 2;
            this.userUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("userUpdate.ImageOptions.Image")));
            this.userUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("userUpdate.ImageOptions.LargeImage")));
            this.userUpdate.Name = "userUpdate";
            this.userUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.userUpdate_ItemClick);
            // 
            // userDelete
            // 
            this.userDelete.Caption = "Kullanıcı Sil";
            this.userDelete.Id = 3;
            this.userDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("userDelete.ImageOptions.Image")));
            this.userDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("userDelete.ImageOptions.LargeImage")));
            this.userDelete.Name = "userDelete";
            this.userDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.userDelete_ItemClick);
            // 
            // DeleteAll
            // 
            this.DeleteAll.Caption = "Hepsini Sil";
            this.DeleteAll.Id = 4;
            this.DeleteAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAll.ImageOptions.Image")));
            this.DeleteAll.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DeleteAll.ImageOptions.LargeImage")));
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteAll_ItemClick);
            // 
            // Excel
            // 
            this.Excel.Caption = "Excel Dönüştürücü";
            this.Excel.Id = 5;
            this.Excel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Excel.ImageOptions.Image")));
            this.Excel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Excel.ImageOptions.LargeImage")));
            this.Excel.Name = "Excel";
            this.Excel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Excel_ItemClick);
            // 
            // PDF
            // 
            this.PDF.Caption = "PDF   Dönüştürücü";
            this.PDF.Id = 6;
            this.PDF.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PDF.ImageOptions.Image")));
            this.PDF.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("PDF.ImageOptions.LargeImage")));
            this.PDF.Name = "PDF";
            this.PDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PDF_ItemClick);
            // 
            // HTML
            // 
            this.HTML.Caption = "HTML   Dönüştürücü";
            this.HTML.Id = 7;
            this.HTML.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HTML.ImageOptions.Image")));
            this.HTML.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("HTML.ImageOptions.LargeImage")));
            this.HTML.Name = "HTML";
            this.HTML.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HTML_ItemClick);
            // 
            // Print
            // 
            this.Print.Caption = "Sayfayı Yazdır";
            this.Print.Id = 8;
            this.Print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Print.ImageOptions.Image")));
            this.Print.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Print.ImageOptions.LargeImage")));
            this.Print.Name = "Print";
            this.Print.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Print_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "İşlemler";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Excel);
            this.ribbonPageGroup1.ItemLinks.Add(this.PDF);
            this.ribbonPageGroup1.ItemLinks.Add(this.HTML);
            this.ribbonPageGroup1.ItemLinks.Add(this.Print);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Dosya İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.userAdd);
            this.ribbonPageGroup2.ItemLinks.Add(this.userUpdate);
            this.ribbonPageGroup2.ItemLinks.Add(this.userDelete);
            this.ribbonPageGroup2.ItemLinks.Add(this.DeleteAll);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Kullanıcı İşlemleri";
            // 
            // gridUser
            // 
            this.gridUser.DataSource = this.userXPBindingSource;
            this.gridUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUser.Location = new System.Drawing.Point(0, 0);
            this.gridUser.MainView = this.gridView1;
            this.gridUser.MenuManager = this.ribbonControl1;
            this.gridUser.Name = "gridUser";
            this.gridUser.Size = new System.Drawing.Size(1178, 637);
            this.gridUser.TabIndex = 1;
            this.gridUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // userXPBindingSource
            // 
            this.userXPBindingSource.ObjectType = typeof(DevExpressXpoDemo.Xdb.User);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colUsername,
            this.colPassword});
            this.gridView1.GridControl = this.gridUser;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 94;
            // 
            // colUsername
            // 
            this.colUsername.FieldName = "Username";
            this.colUsername.MinWidth = 25;
            this.colUsername.Name = "colUsername";
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 1;
            this.colUsername.Width = 94;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.MinWidth = 25;
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 2;
            this.colPassword.Width = 94;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(458, 294);
            this.txtId.MenuManager = this.ribbonControl1;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(125, 22);
            this.txtId.TabIndex = 3;
            this.txtId.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(458, 322);
            this.txtUsername.MenuManager = this.ribbonControl1;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(125, 22);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(458, 350);
            this.txtPassword.MenuManager = this.ribbonControl1;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Visible = false;
            // 
            // userList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 637);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.gridUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtId);
            this.Name = "userList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş";
            this.Load += new System.EventHandler(this.UserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userXPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.Xpo.XPBindingSource userXPBindingSource;
        private DevExpress.XtraBars.BarButtonItem userAdd;
        private DevExpress.XtraBars.BarButtonItem userUpdate;
        private DevExpress.XtraBars.BarButtonItem userDelete;
        private DevExpress.XtraBars.BarButtonItem DeleteAll;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem Excel;
        private DevExpress.XtraBars.BarButtonItem PDF;
        private DevExpress.XtraBars.BarButtonItem HTML;
        private DevExpress.XtraBars.BarButtonItem Print;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
    }
}