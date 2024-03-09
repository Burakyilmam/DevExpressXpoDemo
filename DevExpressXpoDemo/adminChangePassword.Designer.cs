namespace DevExpressXpoDemo
{
    partial class adminChangePassword
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
            this.btnChange = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtOld = new DevExpress.XtraEditors.TextEdit();
            this.txtNew = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNewControl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChange.Appearance.Options.UseFont = true;
            this.btnChange.Location = new System.Drawing.Point(76, 185);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(94, 29);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Değiştir";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(83, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Eski Parola";
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(12, 43);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(222, 22);
            this.txtOld.TabIndex = 2;
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(12, 96);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(222, 22);
            this.txtNew.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(83, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Yeni Parola";
            // 
            // txtNewControl
            // 
            this.txtNewControl.Location = new System.Drawing.Point(12, 147);
            this.txtNewControl.Name = "txtNewControl";
            this.txtNewControl.Size = new System.Drawing.Size(222, 22);
            this.txtNewControl.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(51, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(119, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Yeni Parola Tekrar";
            // 
            // adminChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 231);
            this.Controls.Add(this.txtNewControl);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnChange);
            this.Name = "adminChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Değiştir";
            this.Load += new System.EventHandler(this.adminChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewControl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnChange;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtOld;
        private DevExpress.XtraEditors.TextEdit txtNew;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNewControl;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}