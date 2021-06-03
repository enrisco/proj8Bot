using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using _8Bot_Configuration.Controller;
using _8Bot_Configuration.Model;
using _8Bot_Configuration.View;
using System.Windows.Forms;

namespace _8Bot_Configuration
{
    public partial class FrmConfig : Form
    {
        public static bool isNotfirstTime, canClose = true;
        public static string version = "1.0.0";

        public FrmConfig()
        {
            InitializeComponent();
            isNotfirstTime = InitialCheck();
            Text = Strings.formName;
            Strings.Checklanguage();
            Controls.Add(new UscWelcome());
            
            lblWaterMark.BackColor = Color.Transparent;
            lblWaterMark.Text += " v" + version;
        }

        bool InitialCheck()
        {
            bool _isNotfirstTime = UseXML.CheckifXMLExist();

            return _isNotfirstTime;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!canClose)
                e.Cancel = true;
        }
    }
    
}
