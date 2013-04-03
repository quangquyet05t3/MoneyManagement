namespace MoneyManagement
{
    partial class FrmAbout
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblAuthorEmail = new System.Windows.Forms.Label();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(37, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Money Management";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(296, 24);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(51, 57);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(51, 18);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(51, 91);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(134, 57);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(103, 18);
            this.lblAuthorName.TabIndex = 4;
            this.lblAuthorName.Text = "Johnny Chung";
            // 
            // lblAuthorEmail
            // 
            this.lblAuthorEmail.AutoSize = true;
            this.lblAuthorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorEmail.Location = new System.Drawing.Point(134, 91);
            this.lblAuthorEmail.Name = "lblAuthorEmail";
            this.lblAuthorEmail.Size = new System.Drawing.Size(178, 18);
            this.lblAuthorEmail.TabIndex = 5;
            this.lblAuthorEmail.Text = "chungvithanh@gmail.com";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCopyRight.Location = new System.Drawing.Point(18, 122);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(355, 17);
            this.lblCopyRight.TabIndex = 6;
            this.lblCopyRight.Text = "Copyright ©  2012 by Johnny Chung. All right reserved.";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 154);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.lblAuthorEmail);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblAuthorEmail;
        private System.Windows.Forms.Label lblCopyRight;
    }
}