using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;

namespace MoneyManagement
{
    public partial class FrmAbout : FrmBase
    {
        public FrmAbout()
        {
            InitializeComponent();
            lblVersion.Text = this.ProductVersion;
            LoadCulture();
        }

        private void LoadCulture()
        {
            Language.GetLanguage language = Language.GetLanguage.Instance(PublicVariables.Language);

            this.Text = language.GetString("About");
            lblAuthor.Text = language.GetString("Author");
            lblEmail.Text = language.GetString("Email");
        }
    }
}
