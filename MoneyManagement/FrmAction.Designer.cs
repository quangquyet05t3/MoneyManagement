namespace MoneyManagement
{
    partial class FrmAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAction));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.numericUpDown_Amount = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.dateTimePicker_Time = new System.Windows.Forms.DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.comboBox1);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.lblDate);
            this.groupBox.Controls.Add(this.numericUpDown_Amount);
            this.groupBox.Controls.Add(this.btnSubmit);
            this.groupBox.Controls.Add(this.txtReason);
            this.groupBox.Controls.Add(this.lblReason);
            this.groupBox.Controls.Add(this.dateTimePicker_Time);
            this.groupBox.Controls.Add(this.lblAmount);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(265, 165);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(22, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date";
            // 
            // numericUpDown_Amount
            // 
            this.numericUpDown_Amount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Amount.Location = new System.Drawing.Point(102, 71);
            this.numericUpDown_Amount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown_Amount.Name = "numericUpDown_Amount";
            this.numericUpDown_Amount.Size = new System.Drawing.Size(138, 20);
            this.numericUpDown_Amount.TabIndex = 1;
            this.numericUpDown_Amount.ThousandsSeparator = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(102, 123);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(138, 30);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(102, 97);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(138, 20);
            this.txtReason.TabIndex = 2;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(22, 100);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(44, 13);
            this.lblReason.TabIndex = 6;
            this.lblReason.Text = "Reason";
            // 
            // dateTimePicker_Time
            // 
            this.dateTimePicker_Time.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Time.Location = new System.Drawing.Point(102, 19);
            this.dateTimePicker_Time.Name = "dateTimePicker_Time";
            this.dateTimePicker_Time.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker_Time.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(22, 73);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // FrmAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 189);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action";
            this.Load += new System.EventHandler(this.FrmAction_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDepositWithdraw_FormClosed);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Time;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.NumericUpDown numericUpDown_Amount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;



    }
}

