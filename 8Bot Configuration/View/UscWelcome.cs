using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _8Bot_Configuration.Model;
using System.Windows.Forms;

namespace _8Bot_Configuration.View
{
    public partial class UscWelcome : UserControl, ISetText
    {
        public UscWelcome()
        {
            InitializeComponent();
            SetComponentsText();

            if (FrmConfig.isNotfirstTime)
                btnUninstall.Enabled = true;
        }

        public void SetComponentsText()
        {
            lblDescription.Text = Strings.descWelcome;
            lblTitle.Text = Strings.titleWelcome;
            btnContinue.Text = Strings._btnConfig;
            btnUninstall.Text = Strings._btnUninstall;
        }

        private void On_Button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(btnContinue))
            {
                Parent.Controls.Add(new UscInstall());
                Parent.Controls.Remove(this);
            }
            else if (sender.Equals(btnUninstall))
            {
                
                Parent.Controls.Add(new UscUninstall());

                Parent.Controls.Remove(this);
            }
            
        }
    }
}
