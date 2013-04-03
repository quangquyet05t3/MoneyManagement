namespace MoneyManagement
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vietnameseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton_Day = new System.Windows.Forms.RadioButton();
            this.lblDay = new System.Windows.Forms.Label();
            this.comboBox_Day = new System.Windows.Forms.ComboBox();
            this.comboBox_Month = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.radioButton_Month = new System.Windows.Forms.RadioButton();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.radioButton_Year = new System.Windows.Forms.RadioButton();
            this.dataGridView_Main = new System.Windows.Forms.DataGridView();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActionShow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_DataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.depositToolStripMenuItem_dgv = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem_dgv = new System.Windows.Forms.ToolStripMenuItem();
            this.lendToolStripMenuItem_dgv = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem_dgv = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem_dgv = new System.Windows.Forms.ToolStripMenuItem();
            this.labelOpeningAmount = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelClosingAmount = new System.Windows.Forms.Label();
            this.lblOpeningAmount = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblClosingAmount = new System.Windows.Forms.Label();
            this.btnPresent = new System.Windows.Forms.Button();
            this.checkBox_Deposit = new System.Windows.Forms.CheckBox();
            this.checkBox_Withdraw = new System.Windows.Forms.CheckBox();
            this.checkBox_Lend = new System.Windows.Forms.CheckBox();
            this.checkBox_Borrow = new System.Windows.Forms.CheckBox();
            this.menuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).BeginInit();
            this.contextMenuStrip_DataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip_Main.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(984, 24);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.withdrawToolStripMenuItem,
            this.lendToolStripMenuItem,
            this.borrowToolStripMenuItem});
            this.actionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // lendToolStripMenuItem
            // 
            this.lendToolStripMenuItem.Name = "lendToolStripMenuItem";
            this.lendToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.lendToolStripMenuItem.Text = "Lend";
            this.lendToolStripMenuItem.Click += new System.EventHandler(this.lendToolStripMenuItem_Click);
            // 
            // borrowToolStripMenuItem
            // 
            this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.borrowToolStripMenuItem.Text = "Borrow";
            this.borrowToolStripMenuItem.Click += new System.EventHandler(this.borrowToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.vietnameseToolStripMenuItem});
            this.languageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // vietnameseToolStripMenuItem
            // 
            this.vietnameseToolStripMenuItem.Name = "vietnameseToolStripMenuItem";
            this.vietnameseToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.vietnameseToolStripMenuItem.Text = "Tiếng Việt";
            this.vietnameseToolStripMenuItem.Click += new System.EventHandler(this.vietnameseToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // radioButton_Day
            // 
            this.radioButton_Day.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton_Day.AutoSize = true;
            this.radioButton_Day.Location = new System.Drawing.Point(118, 58);
            this.radioButton_Day.Name = "radioButton_Day";
            this.radioButton_Day.Size = new System.Drawing.Size(14, 13);
            this.radioButton_Day.TabIndex = 1;
            this.radioButton_Day.TabStop = true;
            this.radioButton_Day.UseVisualStyleBackColor = true;
            this.radioButton_Day.CheckedChanged += new System.EventHandler(this.radioButton_Day_CheckedChanged);
            // 
            // lblDay
            // 
            this.lblDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(138, 58);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(26, 13);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "Day";
            // 
            // comboBox_Day
            // 
            this.comboBox_Day.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Day.FormattingEnabled = true;
            this.comboBox_Day.Location = new System.Drawing.Point(170, 55);
            this.comboBox_Day.Name = "comboBox_Day";
            this.comboBox_Day.Size = new System.Drawing.Size(134, 21);
            this.comboBox_Day.TabIndex = 3;
            this.comboBox_Day.SelectedIndexChanged += new System.EventHandler(this.comboBox_Day_SelectedIndexChanged);
            // 
            // comboBox_Month
            // 
            this.comboBox_Month.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Month.FormattingEnabled = true;
            this.comboBox_Month.Location = new System.Drawing.Point(389, 55);
            this.comboBox_Month.Name = "comboBox_Month";
            this.comboBox_Month.Size = new System.Drawing.Size(134, 21);
            this.comboBox_Month.TabIndex = 6;
            this.comboBox_Month.SelectedIndexChanged += new System.EventHandler(this.comboBox_Month_SelectedIndexChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(346, 58);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 5;
            this.lblMonth.Text = "Month";
            // 
            // radioButton_Month
            // 
            this.radioButton_Month.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton_Month.AutoSize = true;
            this.radioButton_Month.Location = new System.Drawing.Point(326, 58);
            this.radioButton_Month.Name = "radioButton_Month";
            this.radioButton_Month.Size = new System.Drawing.Size(14, 13);
            this.radioButton_Month.TabIndex = 4;
            this.radioButton_Month.TabStop = true;
            this.radioButton_Month.UseVisualStyleBackColor = true;
            this.radioButton_Month.CheckedChanged += new System.EventHandler(this.radioButton_Month_CheckedChanged);
            // 
            // comboBox_Year
            // 
            this.comboBox_Year.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Year.FormattingEnabled = true;
            this.comboBox_Year.Location = new System.Drawing.Point(606, 55);
            this.comboBox_Year.Name = "comboBox_Year";
            this.comboBox_Year.Size = new System.Drawing.Size(134, 21);
            this.comboBox_Year.TabIndex = 9;
            this.comboBox_Year.SelectedIndexChanged += new System.EventHandler(this.comboBox_Year_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(571, 58);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year";
            // 
            // radioButton_Year
            // 
            this.radioButton_Year.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton_Year.AutoSize = true;
            this.radioButton_Year.Location = new System.Drawing.Point(551, 58);
            this.radioButton_Year.Name = "radioButton_Year";
            this.radioButton_Year.Size = new System.Drawing.Size(14, 13);
            this.radioButton_Year.TabIndex = 7;
            this.radioButton_Year.TabStop = true;
            this.radioButton_Year.UseVisualStyleBackColor = true;
            this.radioButton_Year.CheckedChanged += new System.EventHandler(this.radioButton_Year_CheckedChanged);
            // 
            // dataGridView_Main
            // 
            this.dataGridView_Main.AllowUserToAddRows = false;
            this.dataGridView_Main.AllowUserToDeleteRows = false;
            this.dataGridView_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Main.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView_Main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAction,
            this.colActionShow,
            this.colAmount,
            this.colReason,
            this.colTime,
            this.colTransactionID});
            this.dataGridView_Main.ContextMenuStrip = this.contextMenuStrip_DataGridView;
            this.dataGridView_Main.Location = new System.Drawing.Point(12, 82);
            this.dataGridView_Main.Name = "dataGridView_Main";
            this.dataGridView_Main.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Main.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SlateGray;
            this.dataGridView_Main.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Main.Size = new System.Drawing.Size(960, 524);
            this.dataGridView_Main.TabIndex = 10;
            // 
            // colAction
            // 
            this.colAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAction.DataPropertyName = "Action";
            dataGridViewCellStyle2.NullValue = null;
            this.colAction.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAction.FillWeight = 30F;
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Visible = false;
            this.colAction.Width = 5;
            // 
            // colActionShow
            // 
            this.colActionShow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colActionShow.FillWeight = 30F;
            this.colActionShow.HeaderText = "ActionShow";
            this.colActionShow.Name = "colActionShow";
            this.colActionShow.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAmount.FillWeight = 50F;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 130;
            // 
            // colReason
            // 
            this.colReason.DataPropertyName = "Reason";
            this.colReason.HeaderText = "Reason";
            this.colReason.Name = "colReason";
            this.colReason.ReadOnly = true;
            // 
            // colTime
            // 
            this.colTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTime.DataPropertyName = "Time";
            this.colTime.FillWeight = 50F;
            this.colTime.HeaderText = "Time";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.Width = 130;
            // 
            // colTransactionID
            // 
            this.colTransactionID.DataPropertyName = "TransactionID";
            this.colTransactionID.HeaderText = "TransactionID";
            this.colTransactionID.Name = "colTransactionID";
            this.colTransactionID.ReadOnly = true;
            this.colTransactionID.Visible = false;
            // 
            // contextMenuStrip_DataGridView
            // 
            this.contextMenuStrip_DataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem_dgv,
            this.withdrawToolStripMenuItem_dgv,
            this.lendToolStripMenuItem_dgv,
            this.borrowToolStripMenuItem_dgv,
            this.removeToolStripMenuItem_dgv});
            this.contextMenuStrip_DataGridView.Name = "contextMenuStrip_DataGridView";
            this.contextMenuStrip_DataGridView.Size = new System.Drawing.Size(126, 114);
            // 
            // depositToolStripMenuItem_dgv
            // 
            this.depositToolStripMenuItem_dgv.Name = "depositToolStripMenuItem_dgv";
            this.depositToolStripMenuItem_dgv.Size = new System.Drawing.Size(125, 22);
            this.depositToolStripMenuItem_dgv.Text = "Deposit";
            this.depositToolStripMenuItem_dgv.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem_dgv
            // 
            this.withdrawToolStripMenuItem_dgv.Name = "withdrawToolStripMenuItem_dgv";
            this.withdrawToolStripMenuItem_dgv.Size = new System.Drawing.Size(125, 22);
            this.withdrawToolStripMenuItem_dgv.Text = "Withdraw";
            this.withdrawToolStripMenuItem_dgv.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // lendToolStripMenuItem_dgv
            // 
            this.lendToolStripMenuItem_dgv.Name = "lendToolStripMenuItem_dgv";
            this.lendToolStripMenuItem_dgv.Size = new System.Drawing.Size(125, 22);
            this.lendToolStripMenuItem_dgv.Text = "Lend";
            this.lendToolStripMenuItem_dgv.Click += new System.EventHandler(this.lendToolStripMenuItem_Click);
            // 
            // borrowToolStripMenuItem_dgv
            // 
            this.borrowToolStripMenuItem_dgv.Name = "borrowToolStripMenuItem_dgv";
            this.borrowToolStripMenuItem_dgv.Size = new System.Drawing.Size(125, 22);
            this.borrowToolStripMenuItem_dgv.Text = "Borrow";
            this.borrowToolStripMenuItem_dgv.Click += new System.EventHandler(this.borrowToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem_dgv
            // 
            this.removeToolStripMenuItem_dgv.Name = "removeToolStripMenuItem_dgv";
            this.removeToolStripMenuItem_dgv.Size = new System.Drawing.Size(125, 22);
            this.removeToolStripMenuItem_dgv.Text = "Remove";
            this.removeToolStripMenuItem_dgv.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // labelOpeningAmount
            // 
            this.labelOpeningAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOpeningAmount.AutoSize = true;
            this.labelOpeningAmount.Location = new System.Drawing.Point(24, 620);
            this.labelOpeningAmount.Name = "labelOpeningAmount";
            this.labelOpeningAmount.Size = new System.Drawing.Size(89, 13);
            this.labelOpeningAmount.TabIndex = 11;
            this.labelOpeningAmount.Text = "Opening Amount:";
            // 
            // labelAmount
            // 
            this.labelAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(419, 620);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(46, 13);
            this.labelAmount.TabIndex = 12;
            this.labelAmount.Text = "Amount:";
            // 
            // labelClosingAmount
            // 
            this.labelClosingAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClosingAmount.AutoSize = true;
            this.labelClosingAmount.Location = new System.Drawing.Point(761, 620);
            this.labelClosingAmount.Name = "labelClosingAmount";
            this.labelClosingAmount.Size = new System.Drawing.Size(83, 13);
            this.labelClosingAmount.TabIndex = 13;
            this.labelClosingAmount.Text = "Closing Amount:";
            // 
            // lblOpeningAmount
            // 
            this.lblOpeningAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpeningAmount.AutoSize = true;
            this.lblOpeningAmount.Location = new System.Drawing.Point(119, 620);
            this.lblOpeningAmount.Name = "lblOpeningAmount";
            this.lblOpeningAmount.Size = new System.Drawing.Size(35, 13);
            this.lblOpeningAmount.TabIndex = 14;
            this.lblOpeningAmount.Text = "label7";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(471, 620);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(35, 13);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "label8";
            // 
            // lblClosingAmount
            // 
            this.lblClosingAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClosingAmount.AutoSize = true;
            this.lblClosingAmount.Location = new System.Drawing.Point(850, 620);
            this.lblClosingAmount.Name = "lblClosingAmount";
            this.lblClosingAmount.Size = new System.Drawing.Size(35, 13);
            this.lblClosingAmount.TabIndex = 16;
            this.lblClosingAmount.Text = "label9";
            // 
            // btnPresent
            // 
            this.btnPresent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPresent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPresent.Location = new System.Drawing.Point(762, 55);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(80, 21);
            this.btnPresent.TabIndex = 17;
            this.btnPresent.Text = "Present";
            this.btnPresent.UseVisualStyleBackColor = true;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // checkBox_Deposit
            // 
            this.checkBox_Deposit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox_Deposit.AutoSize = true;
            this.checkBox_Deposit.Checked = true;
            this.checkBox_Deposit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Deposit.Location = new System.Drawing.Point(181, 32);
            this.checkBox_Deposit.Name = "checkBox_Deposit";
            this.checkBox_Deposit.Size = new System.Drawing.Size(62, 17);
            this.checkBox_Deposit.TabIndex = 18;
            this.checkBox_Deposit.Text = "Deposit";
            this.checkBox_Deposit.UseVisualStyleBackColor = true;
            this.checkBox_Deposit.CheckedChanged += new System.EventHandler(this.checkBox_Deposit_CheckedChanged);
            // 
            // checkBox_Withdraw
            // 
            this.checkBox_Withdraw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox_Withdraw.AutoSize = true;
            this.checkBox_Withdraw.Checked = true;
            this.checkBox_Withdraw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Withdraw.Location = new System.Drawing.Point(352, 32);
            this.checkBox_Withdraw.Name = "checkBox_Withdraw";
            this.checkBox_Withdraw.Size = new System.Drawing.Size(71, 17);
            this.checkBox_Withdraw.TabIndex = 19;
            this.checkBox_Withdraw.Text = "Withdraw";
            this.checkBox_Withdraw.UseVisualStyleBackColor = true;
            this.checkBox_Withdraw.CheckedChanged += new System.EventHandler(this.checkBox_Withdraw_CheckedChanged);
            // 
            // checkBox_Lend
            // 
            this.checkBox_Lend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox_Lend.AutoSize = true;
            this.checkBox_Lend.Checked = true;
            this.checkBox_Lend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Lend.Location = new System.Drawing.Point(534, 32);
            this.checkBox_Lend.Name = "checkBox_Lend";
            this.checkBox_Lend.Size = new System.Drawing.Size(50, 17);
            this.checkBox_Lend.TabIndex = 20;
            this.checkBox_Lend.Text = "Lend";
            this.checkBox_Lend.UseVisualStyleBackColor = true;
            this.checkBox_Lend.CheckedChanged += new System.EventHandler(this.checkBox_Lend_CheckedChanged);
            // 
            // checkBox_Borrow
            // 
            this.checkBox_Borrow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox_Borrow.AutoSize = true;
            this.checkBox_Borrow.Checked = true;
            this.checkBox_Borrow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Borrow.Location = new System.Drawing.Point(709, 32);
            this.checkBox_Borrow.Name = "checkBox_Borrow";
            this.checkBox_Borrow.Size = new System.Drawing.Size(59, 17);
            this.checkBox_Borrow.TabIndex = 21;
            this.checkBox_Borrow.Text = "Borrow";
            this.checkBox_Borrow.UseVisualStyleBackColor = true;
            this.checkBox_Borrow.CheckedChanged += new System.EventHandler(this.checkBox_Borrow_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 647);
            this.Controls.Add(this.checkBox_Borrow);
            this.Controls.Add(this.checkBox_Lend);
            this.Controls.Add(this.checkBox_Withdraw);
            this.Controls.Add(this.lblClosingAmount);
            this.Controls.Add(this.checkBox_Deposit);
            this.Controls.Add(this.lblOpeningAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.labelClosingAmount);
            this.Controls.Add(this.btnPresent);
            this.Controls.Add(this.labelOpeningAmount);
            this.Controls.Add(this.dataGridView_Main);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.menuStrip_Main);
            this.Controls.Add(this.comboBox_Day);
            this.Controls.Add(this.radioButton_Day);
            this.Controls.Add(this.comboBox_Year);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.radioButton_Year);
            this.Controls.Add(this.comboBox_Month);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.radioButton_Month);
            this.Controls.Add(this.lblDay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Management";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).EndInit();
            this.contextMenuStrip_DataGridView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton_Day;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ComboBox comboBox_Day;
        private System.Windows.Forms.ComboBox comboBox_Month;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.RadioButton radioButton_Month;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.RadioButton radioButton_Year;
        private System.Windows.Forms.DataGridView dataGridView_Main;
        private System.Windows.Forms.Label labelOpeningAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelClosingAmount;
        private System.Windows.Forms.Label lblOpeningAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblClosingAmount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_DataGridView;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem_dgv;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem_dgv;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vietnameseToolStripMenuItem;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionID;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem_dgv;
        private System.Windows.Forms.ToolStripMenuItem lendToolStripMenuItem_dgv;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem_dgv;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_Deposit;
        private System.Windows.Forms.CheckBox checkBox_Withdraw;
        private System.Windows.Forms.CheckBox checkBox_Lend;
        private System.Windows.Forms.CheckBox checkBox_Borrow;
    }
}