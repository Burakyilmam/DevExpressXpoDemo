namespace DevExpressXpoDemo
{
    partial class adminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLogin));
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.btnEye = new DevExpress.XtraEditors.SimpleButton();
            this.btnEyeClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Location = new System.Drawing.Point(75, 154);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parola";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(43, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(175, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yönetici Adı";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(43, 62);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(175, 22);
            this.txtUsername.TabIndex = 5;
            // 
            // btnEye
            // 
            this.btnEye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEye.ImageOptions.Image")));
            this.btnEye.Location = new System.Drawing.Point(224, 116);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(36, 19);
            this.btnEye.TabIndex = 10;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            // 
            // btnEyeClose
            // 
            this.btnEyeClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEyeClose.ImageOptions.Image")));
            this.btnEyeClose.Location = new System.Drawing.Point(224, 116);
            this.btnEyeClose.Name = "btnEyeClose";
            this.btnEyeClose.Size = new System.Drawing.Size(36, 19);
            this.btnEyeClose.TabIndex = 11;
            this.btnEyeClose.Click += new System.EventHandler(this.btnEyeClose_Click);
            // 
            // adminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 210);
            this.Controls.Add(this.btnEye);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnEyeClose);
            this.Name = "adminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminLogin_FormClosing);
            this.Load += new System.EventHandler(this.adminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.SimpleButton btnEye;
        private DevExpress.XtraEditors.SimpleButton btnEyeClose;
    }
}