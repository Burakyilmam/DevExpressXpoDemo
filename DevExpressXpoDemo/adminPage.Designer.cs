namespace DevExpressXpoDemo
{
    partial class adminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPage));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Logout = new DevExpress.XtraBars.BarButtonItem();
            this.AdminInfo = new DevExpress.XtraBars.BarButtonItem();
            this.ChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.PdfViewer = new DevExpress.XtraBars.BarButtonItem();
            this.TextEditor = new DevExpress.XtraBars.BarButtonItem();
            this.ExcelViewer = new DevExpress.XtraBars.BarButtonItem();
            this.DocumentViewer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.Logout,
            this.AdminInfo,
            this.ChangePassword,
            this.PdfViewer,
            this.TextEditor,
            this.ExcelViewer,
            this.DocumentViewer,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1046, 183);
            // 
            // Logout
            // 
            this.Logout.Caption = "Çıkış Yap";
            this.Logout.Id = 1;
            this.Logout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Logout.ImageOptions.Image")));
            this.Logout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Logout.ImageOptions.LargeImage")));
            this.Logout.Name = "Logout";
            this.Logout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Logout_ItemClick);
            // 
            // AdminInfo
            // 
            this.AdminInfo.Caption = "Yönetici Bilgileri";
            this.AdminInfo.Id = 2;
            this.AdminInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AdminInfo.ImageOptions.Image")));
            this.AdminInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("AdminInfo.ImageOptions.LargeImage")));
            this.AdminInfo.Name = "AdminInfo";
            this.AdminInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AdminInfo_ItemClick);
            // 
            // ChangePassword
            // 
            this.ChangePassword.Caption = "Parola Değiştir";
            this.ChangePassword.Id = 3;
            this.ChangePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ChangePassword.ImageOptions.Image")));
            this.ChangePassword.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ChangePassword.ImageOptions.LargeImage")));
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChangePassword_ItemClick);
            // 
            // PdfViewer
            // 
            this.PdfViewer.Caption = "PDF   Görüntüleme";
            this.PdfViewer.Id = 4;
            this.PdfViewer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PdfViewer.ImageOptions.Image")));
            this.PdfViewer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("PdfViewer.ImageOptions.LargeImage")));
            this.PdfViewer.Name = "PdfViewer";
            this.PdfViewer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PdfViewer_ItemClick);
            // 
            // TextEditor
            // 
            this.TextEditor.Caption = "Metin Editörü";
            this.TextEditor.Id = 5;
            this.TextEditor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TextEditor.ImageOptions.Image")));
            this.TextEditor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("TextEditor.ImageOptions.LargeImage")));
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TextEditor_ItemClick);
            // 
            // ExcelViewer
            // 
            this.ExcelViewer.Caption = "Excel Görüntüleme";
            this.ExcelViewer.Id = 6;
            this.ExcelViewer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ExcelViewer.ImageOptions.Image")));
            this.ExcelViewer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ExcelViewer.ImageOptions.LargeImage")));
            this.ExcelViewer.Name = "ExcelViewer";
            this.ExcelViewer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExcelViewer_ItemClick);
            // 
            // DocumentViewer
            // 
            this.DocumentViewer.Caption = "Doküman Görüntüleme";
            this.DocumentViewer.Id = 7;
            this.DocumentViewer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DocumentViewer.ImageOptions.Image")));
            this.DocumentViewer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DocumentViewer.ImageOptions.LargeImage")));
            this.DocumentViewer.Name = "DocumentViewer";
            this.DocumentViewer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DocumentViewer_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "İşlemler";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Logout);
            this.ribbonPageGroup1.ItemLinks.Add(this.AdminInfo);
            this.ribbonPageGroup1.ItemLinks.Add(this.ChangePassword);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Oturum İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.PdfViewer);
            this.ribbonPageGroup2.ItemLinks.Add(this.ExcelViewer);
            this.ribbonPageGroup2.ItemLinks.Add(this.TextEditor);
            this.ribbonPageGroup2.ItemLinks.Add(this.DocumentViewer);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Dosya İşlemleri";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Hesap Makinesi";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Mail   Gönder";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // adminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 604);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "adminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Logout;
        private DevExpress.XtraBars.BarButtonItem AdminInfo;
        private DevExpress.XtraBars.BarButtonItem ChangePassword;
        private DevExpress.XtraBars.BarButtonItem PdfViewer;
        private DevExpress.XtraBars.BarButtonItem TextEditor;
        private DevExpress.XtraBars.BarButtonItem ExcelViewer;
        private DevExpress.XtraBars.BarButtonItem DocumentViewer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}