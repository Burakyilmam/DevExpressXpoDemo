namespace DevExpressXpoDemo
{
    partial class Opening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opening));
            this.userBtn = new DevExpress.XtraEditors.SimpleButton();
            this.adminBtn = new DevExpress.XtraEditors.SimpleButton();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userBtn
            // 
            this.userBtn.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.userBtn.Appearance.Options.UseBackColor = true;
            this.userBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.userBtn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.userBtn.Location = new System.Drawing.Point(29, 3);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(154, 154);
            this.userBtn.TabIndex = 0;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.adminBtn.Appearance.Options.UseBackColor = true;
            this.adminBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.adminBtn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.adminBtn.Location = new System.Drawing.Point(224, 3);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(154, 154);
            this.adminBtn.TabIndex = 1;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.Location = new System.Drawing.Point(55, 160);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(97, 24);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Kullanıcı";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdmin.Location = new System.Drawing.Point(250, 160);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(91, 24);
            this.lblAdmin.TabIndex = 3;
            this.lblAdmin.Text = "Yönetici";
            // 
            // Opening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 201);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.userBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Opening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Opening_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton userBtn;
        private DevExpress.XtraEditors.SimpleButton adminBtn;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblAdmin;
    }
}

