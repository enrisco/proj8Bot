using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _8Bot_Configuration.Model;

namespace _8Bot_Configuration.View
{
    public partial class UscFinally : UserControl, ISetText
    {
        string desc;
        public UscFinally(string _desc)
        {
            InitializeComponent();
            desc = _desc;
            SetComponentsText();
        }

        public void SetComponentsText()
        {
            lblTitle.Text = Strings.titleFinally;
            lblDescription.Text = desc;
            btnClose.Text = Strings._btnFinally;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
