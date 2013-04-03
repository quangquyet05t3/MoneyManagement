using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Resources;

namespace MoneyManagement
{
    public partial class FrmAction : FrmBase
    {
        private Ultity.Action actionID;
        public static FrmAction _frmAction;

        public FrmAction(Ultity.Action p_Action, DateTime p_DateTime)
        {
            InitializeComponent();
            dateTimePicker_Time.Value = p_DateTime;
            actionID = p_Action;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Transaction obTransaction = new Transaction();
            obTransaction.TransactionID = PublicFunction.EncryptPassword(DateTime.Now.ToString());
            obTransaction.Action = (int)actionID;
            obTransaction.Amount = (int)numericUpDown_Amount.Value;
            obTransaction.Reason = txtReason.Text;
            obTransaction.Time = dateTimePicker_Time.Value;

            Data obData = PublicVariables.listData.Find(ob => ob.Year == obTransaction.Time.Year);
            if (obData == null)
            {
                obData = new Data();
                obData.Year = obTransaction.Time.Year;
                List<Transaction> listTransaction = new List<Transaction>();
                listTransaction.Add(obTransaction);
                obData.Transactions = listTransaction;
                PublicFunction.WriteData(obData.Year, obData);
            }
            else
            {
                obData.Transactions.Add(obTransaction);
                PublicFunction.WriteData(obData.Year, obData);
            }

            this.Hide();
        }

        private void FrmDepositWithdraw_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void LoadCulture()
        {
            Language.GetLanguage language = Language.GetLanguage.Instance(PublicVariables.Language);
            lblDate.Text = language.GetString("Date");
            lblAmount.Text = language.GetString("Amount");
            lblReason.Text = language.GetString("Reason");
            btnSubmit.Text = language.GetString("Submit");
            if (actionID == Ultity.Action.Deposit)
                this.Text = language.GetString("Deposit");
            else if (actionID == Ultity.Action.Withdraw)
                this.Text = language.GetString("Withdraw");
            else if (actionID == Ultity.Action.Lend)
                this.Text = language.GetString("Lend");
            else
                this.Text = language.GetString("Borrow");
        }

        private void FrmAction_Load(object sender, EventArgs e)
        {
            LoadCulture();
        }
    }
}
