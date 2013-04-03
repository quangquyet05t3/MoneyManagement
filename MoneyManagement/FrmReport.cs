using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MoneyManagement
{
    public partial class FrmReport : MoneyManagement.FrmBase
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
