using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Resources;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Diagnostics;
using System.Reflection;

namespace MoneyManagement
{
    public partial class FrmMain : FrmBase
    {
        private int Day = 0;
        private int Month = 0;
        private int Year = 0;
        private bool isDeposit = true;
        private bool isWithdraw = true;
        private bool isLend = true;
        private bool isBorrow = true;
        private Ultity.DataType DataType = Ultity.DataType.Day;

        public FrmMain()
        {
            InitializeComponent();

            PublicVariables.listData = PublicFunction.ReadData();
            PublicVariables.Language = Language.Language.English;
            LoadCulture();
        }

        private static int CompareDataTime(Transaction x, Transaction y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    // If x is null and y is null, they're 
                    // equal.  
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y 
                    // is greater.  
                    return -1;
                }
            }
            else
            {
                // If x is not null... 
                // 
                if (y == null)
                // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    // ...and y is not null, compare the  
                    // lengths of the two strings. 
                    // 
                    int retval = x.Time.CompareTo(y.Time);

                    if (retval != 0)
                    {
                        // If the strings are not of equal length, 
                        // the longer string is greater. 
                        // 
                        return retval;
                    }
                    else
                    {
                        // If the strings are of equal length, 
                        // sort them with ordinary string comparison. 
                        // 
                        return x.Time.CompareTo(y.Time);
                    }
                }
            }
        }
        
        private void LoadData()
        {
            Data obData = null;

            for (int i = 0; i < PublicVariables.listData.Count; i++)
            {
                if (PublicVariables.listData[i].Year == Year)
                    obData = new Data(PublicVariables.listData[i]);
            }

            List<Transaction> listTransSource = new List<Transaction>();
            List<Transaction> listTransSourceOpening = new List<Transaction>();
            int Amount = 0;
            int OpeningAmount = 0;

            if (obData != null)
            {
                if (DataType == Ultity.DataType.Day)
                {
                    listTransSource = obData.Transactions.FindAll(ob => ob.Time.Day == Day && ob.Time.Month == Month);
                    listTransSourceOpening = obData.Transactions.FindAll(ob => ob.Time < new DateTime(Year, Month, Day));
                }
                else if (DataType == Ultity.DataType.Month)
                {
                    listTransSource = obData.Transactions.FindAll(ob => ob.Time.Month == Month);
                    listTransSourceOpening = obData.Transactions.FindAll(ob => ob.Time < new DateTime(Year, Month, 1));
                }
                else
                {
                    listTransSource = obData.Transactions;
                    listTransSourceOpening = obData.Transactions.FindAll(ob => ob.Time < new DateTime(Year, 1, 1));
                }
            }

            for (int i = Ultity.YearStart; i < Year; i++)
            {
                Data obDataOpening = new Data(PublicVariables.listData[i]);
                if (obDataOpening != null)
                {
                    listTransSourceOpening.AddRange(obDataOpening.Transactions);
                }
            }

            dataGridView_Main.DataSource = listTransSource.FindAll(ob => 
            {
                bool flag = false;
                if (isDeposit && (ob.Action == (int)Ultity.Action.Deposit))
                    flag = true;
                else if (isWithdraw && (ob.Action == (int)Ultity.Action.Withdraw))
                    flag = true;
                else if (isLend && (ob.Action == (int)Ultity.Action.Lend))
                    flag = true;
                else if (isBorrow && (ob.Action == (int)Ultity.Action.Borrow))
                    flag = true;
                return flag;
            });

            listTransSource.ForEach(ob =>
            {
                if (ob.Action == (int)Ultity.Action.Deposit || ob.Action == (int)Ultity.Action.Borrow)
                    Amount += ob.Amount;
                else
                    Amount -= ob.Amount;
            });

            listTransSourceOpening.ForEach(ob =>
            {
                if (ob.Action == (int)Ultity.Action.Deposit || ob.Action == (int)Ultity.Action.Borrow)
                    OpeningAmount += ob.Amount;
                else
                    OpeningAmount -= ob.Amount;
            });

            lblAmount.Text = Amount.ToString("N0");
            lblOpeningAmount.Text = OpeningAmount.ToString("N0");
            lblClosingAmount.Text = (OpeningAmount + Amount).ToString("N0");

            LoadCultureDataGrid();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            comboBox_Year.Items.Clear();
            for (int i = Ultity.YearStart; i <= DateTime.Now.Year; i++)
            {
                comboBox_Year.Items.Add(i);
            }
            comboBox_Year.SelectedIndex = DateTime.Now.Year - Ultity.YearStart;

            comboBox_Month.Items.Clear();
            for (int i = Ultity.MonthStart; i <= 12; i++)
            {
                comboBox_Month.Items.Add(i);
            }
            comboBox_Month.SelectedIndex = DateTime.Now.Month - Ultity.MonthStart;

            comboBox_Day.Items.Clear();
            for (int i = Ultity.DayStart; i <= DateTime.DaysInMonth(DateTime.Now.Year, Month); i++)
            {
                comboBox_Day.Items.Add(i);
            }
            comboBox_Day.SelectedIndex = DateTime.Now.Day - Ultity.DayStart;
        }

        private void radioButton_Day_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Day.Checked)
            {
                DataType = Ultity.DataType.Day;
                LoadData();
            }
        }

        private void radioButton_Month_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Month.Checked)
            {
                DataType = Ultity.DataType.Month;
                LoadData();
            }
        }

        private void radioButton_Year_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Year.Checked)
            {
                DataType = Ultity.DataType.Year;
                LoadData();
            }
        }

        private void comboBox_Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            Day = comboBox_Day.SelectedIndex + Ultity.DayStart;
            if (radioButton_Day.Checked)
            {
                DataType = Ultity.DataType.Day;
                LoadData();
            }
            else if (radioButton_Month.Checked)
            {
                DataType = Ultity.DataType.Month;
                LoadData();
            }
            else if (radioButton_Year.Checked)
            {
                DataType = Ultity.DataType.Year;
                LoadData();
            }
        }

        private void comboBox_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            Month = comboBox_Month.SelectedIndex + Ultity.MonthStart;
            comboBox_Day.Items.Clear();
            for (int i = Ultity.DayStart; i <= DateTime.DaysInMonth(Year, Month); i++)
            {
                comboBox_Day.Items.Add(i);
            }
            int difDay = Day - Ultity.DayStart;
            if (comboBox_Day.Items.Count <= difDay)
                comboBox_Day.SelectedIndex = comboBox_Day.Items.Count - 1;
            else
                comboBox_Day.SelectedIndex = difDay;
        }

        private void comboBox_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            Year = comboBox_Year.SelectedIndex + Ultity.YearStart;
            if (Month > 0)
            {
                comboBox_Day.Items.Clear();
                for (int i = Ultity.DayStart; i <= DateTime.DaysInMonth(Year, Month); i++)
                {
                    comboBox_Day.Items.Add(i);
                }
                int difDay = Day - Ultity.DayStart;
                if (comboBox_Day.Items.Count <= difDay)
                    comboBox_Day.SelectedIndex = comboBox_Day.Items.Count - 1;
                else
                    comboBox_Day.SelectedIndex = difDay;
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection drArr = dataGridView_Main.SelectedRows;
            if (drArr.Count > 0)
            {
                if (MessageBox.Show(PublicVariables.MessageDelete, PublicVariables.CaptionDelete, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Data obData = PublicVariables.listData.Find(ob => ob.Year == Year);
                    if (obData != null)
                    {
                        for (int i = 0; i < drArr.Count; i++)
                        {
                            int idx = obData.Transactions.FindIndex(ob => ob.TransactionID == drArr[i].Cells[colTransactionID.Name].Value.ToString());
                            if (idx >= 0)
                            {
                                obData.Transactions.RemoveAt(idx);
                            }
                        }
                    }
                    PublicFunction.WriteData(Year, obData);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show(PublicVariables.MessageDeleteUnable, PublicVariables.CaptionDelete, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            comboBox_Year.SelectedIndex = DateTime.Now.Year - Ultity.YearStart;
            comboBox_Month.SelectedIndex = DateTime.Now.Month - Ultity.MonthStart;
            comboBox_Day.SelectedIndex = DateTime.Now.Day - Ultity.DayStart;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PublicVariables.Language != Language.Language.English)
            {
                PublicVariables.Language = Language.Language.English;
                LoadCulture();
                LoadCultureDataGrid();
            }
        }

        private void vietnameseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PublicVariables.Language != Language.Language.Vietnamese)
            {
                PublicVariables.Language = Language.Language.Vietnamese;
                LoadCulture();
                LoadCultureDataGrid();
            }
        }

        private void LoadCulture()
        {
            try
            {
                Language.GetLanguage language = Language.GetLanguage.Instance(PublicVariables.Language);

                lblDay.Text = language.GetString("Day");
                lblMonth.Text = language.GetString("Month");
                lblYear.Text = language.GetString("Year");
                btnPresent.Text = language.GetString("Present");
                fileToolStripMenuItem.Text = language.GetString("File");
                exitToolStripMenuItem.Text = language.GetString("Exit");
                actionToolStripMenuItem.Text = language.GetString("Action");
                depositToolStripMenuItem.Text = language.GetString("Deposit");
                withdrawToolStripMenuItem.Text = language.GetString("Withdraw");
                lendToolStripMenuItem.Text = language.GetString("Lend");
                borrowToolStripMenuItem.Text = language.GetString("Borrow");
                languageToolStripMenuItem.Text = language.GetString("Language");
                aboutToolStripMenuItem.Text = language.GetString("About");
                labelOpeningAmount.Text = language.GetString("OpeningAmount");
                labelAmount.Text = language.GetString("Amount");
                labelClosingAmount.Text = language.GetString("ClosingAmount");
                depositToolStripMenuItem_dgv.Text = language.GetString("Deposit");
                withdrawToolStripMenuItem_dgv.Text = language.GetString("Withdraw");
                lendToolStripMenuItem_dgv.Text = language.GetString("Lend");
                borrowToolStripMenuItem_dgv.Text = language.GetString("Borrow");
                removeToolStripMenuItem_dgv.Text = language.GetString("Remove");
                updateToolStripMenuItem.Text = language.GetString("Update");
                reportToolStripMenuItem.Text = language.GetString("Report");

                checkBox_Deposit.Text = language.GetString("Deposit");
                checkBox_Withdraw.Text = language.GetString("Withdraw");
                checkBox_Lend.Text = language.GetString("Lend");
                checkBox_Borrow.Text = language.GetString("Borrow");

                dataGridView_Main.Columns[colAction.Name].HeaderText = language.GetString("Action");
                dataGridView_Main.Columns[colActionShow.Name].HeaderText = language.GetString("Action");
                dataGridView_Main.Columns[colReason.Name].HeaderText = language.GetString("Reason");
                dataGridView_Main.Columns[colAmount.Name].HeaderText = language.GetString("Amount");
                dataGridView_Main.Columns[colTime.Name].HeaderText = language.GetString("Date");

                PublicVariables.MessageError = language.GetString("MessageError");
                PublicVariables.CaptionError = language.GetString("CaptionError");
                PublicVariables.MessageDelete = language.GetString("MessageDelete");
                PublicVariables.CaptionDelete = language.GetString("CaptionDelete");
                PublicVariables.MessageDeleteError = language.GetString("MessageDeleteError");
                PublicVariables.MessageDeleteUnable = language.GetString("MessageDeleteUnable");
                PublicVariables.MessageUnderConstruction = language.GetString("MessageUnderConstruction");
                PublicVariables.CaptionUnderConstruction = language.GetString("CaptionUnderConstruction");
            }
            catch (Exception ex)
            {
                PublicFunction.WriteLog(PublicVariables.AppCulture.EnglishName + " - Details: " + ex.Message);
            }
        }

        private void LoadCultureDataGrid()
        {
            Language.GetLanguage language = Language.GetLanguage.Instance(PublicVariables.Language);

            for (int i = 0; i < dataGridView_Main.Rows.Count; i++)
            {
                int actionID = (int)dataGridView_Main.Rows[i].Cells[colAction.Name].Value;
                if (actionID == 1)
                {
                    dataGridView_Main.Rows[i].Cells[colActionShow.Name].Value = language.GetString("Deposit");
                }
                else if (actionID == 2)
                {
                    dataGridView_Main.Rows[i].Cells[colActionShow.Name].Value = language.GetString("Withdraw");
                }
                else if (actionID == 3)
                {
                    dataGridView_Main.Rows[i].Cells[colActionShow.Name].Value = language.GetString("Lend");
                }
                else
                {
                    dataGridView_Main.Rows[i].Cells[colActionShow.Name].Value = language.GetString("Borrow");
                }
            }
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmAction frm = new FrmAction(Ultity.Action.Deposit, new DateTime(Year, Month, Day)))
            {
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                    LoadData();
                }
            }
        }
        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmAction frm = new FrmAction(Ultity.Action.Withdraw, new DateTime(Year, Month, Day)))
            {
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                    LoadData();
                }
            }
        }
        private void lendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmAction frm = new FrmAction(Ultity.Action.Lend, new DateTime(Year, Month, Day)))
            {
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                    LoadData();
                }
            }
        }
        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmAction frm = new FrmAction(Ultity.Action.Borrow, new DateTime(Year, Month, Day)))
            {
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                    LoadData();
                }
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Author: Johnny Chung\nEmail: chungvithanh@gmail.com", aboutToolStripMenuItem.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PublicVariables.MessageUnderConstruction, PublicVariables.CaptionUnderConstruction, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PublicVariables.MessageUnderConstruction, PublicVariables.CaptionUnderConstruction, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //this.Hide();
            //using (FrmReport frm = new FrmReport())
            //{
            //    if (frm.ShowDialog() == DialogResult.Cancel)
            //    {
            //        this.Show();
            //        LoadData();
            //    }
            //}
        }
        private void checkBox_Deposit_CheckedChanged(object sender, EventArgs e)
        {
            isDeposit = checkBox_Deposit.Checked;
            LoadData();
        }
        private void checkBox_Withdraw_CheckedChanged(object sender, EventArgs e)
        {
            isWithdraw = checkBox_Withdraw.Checked;
            LoadData();
        }
        private void checkBox_Lend_CheckedChanged(object sender, EventArgs e)
        {
            isLend = checkBox_Lend.Checked;
            LoadData();
        }
        private void checkBox_Borrow_CheckedChanged(object sender, EventArgs e)
        {
            isBorrow = checkBox_Borrow.Checked;
            LoadData();
        }
    }
}
