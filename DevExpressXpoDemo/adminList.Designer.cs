namespace DevExpressXpoDemo
{
    partial class adminList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminList));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridUser = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Excel = new DevExpress.XtraBars.BarButtonItem();
            this.PDF = new DevExpress.XtraBars.BarButtonItem();
            this.HTML = new DevExpress.XtraBars.BarButtonItem();
            this.Print = new DevExpress.XtraBars.BarButtonItem();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.Excel,
            this.PDF,
            this.HTML,
            this.Print});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(998, 183);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
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
            // gridUser
            // 
            this.gridUser.DataSource = this.xpCollection1;
            this.gridUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUser.Location = new System.Drawing.Point(0, 183);
            this.gridUser.MainView = this.gridView1;
            this.gridUser.MenuManager = this.ribbonControl1;
            this.gridUser.Name = "gridUser";
            this.gridUser.Size = new System.Drawing.Size(998, 494);
            this.gridUser.TabIndex = 1;
            this.gridUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colUsername,
            this.colPassword,
            this.colStatus});
            this.gridView1.GridControl = this.gridUser;
            this.gridView1.Name = "gridView1";
            // 
            // Excel
            // 
            this.Excel.Caption = "Excel Dönüştür";
            this.Excel.Id = 1;
            this.Excel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.Excel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.Excel.Name = "Excel";
            // 
            // PDF
            // 
            this.PDF.Caption = "PDF Dönüştür";
            this.PDF.Id = 2;
            this.PDF.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.PDF.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.PDF.Name = "PDF";
            // 
            // HTML
            // 
            this.HTML.Caption = "HTML Dönüştür";
            this.HTML.Id = 3;
            this.HTML.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.HTML.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.HTML.Name = "HTML";
            // 
            // Print
            // 
            this.Print.Caption = "Sayfayı Yazdır";
            this.Print.Id = 4;
            this.Print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.Print.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.Print.Name = "Print";
            // 
            // xpCollection1
            // 
            this.xpCollection1.DisplayableProperties = "Id;Username;Password;Status";
            this.xpCollection1.ObjectType = typeof(DevExpressXpoDemo.Xdb.User);
            this.xpCollection1.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[Id]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
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
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 25;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            this.colStatus.Width = 94;
            // 
            // userList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 677);
            this.Controls.Add(this.gridUser);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "userList";
            this.Text = "userList";
            this.Load += new System.EventHandler(this.userList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Excel;
        private DevExpress.XtraBars.BarButtonItem PDF;
        private DevExpress.XtraBars.BarButtonItem HTML;
        private DevExpress.XtraBars.BarButtonItem Print;
        private DevExpress.XtraGrid.GridControl gridUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}