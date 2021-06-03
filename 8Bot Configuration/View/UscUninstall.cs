using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _8Bot_Configuration.Model;
using _8Bot_Configuration.Controller;

namespace _8Bot_Configuration.View
{
    public partial class UscUninstall : UserControl, ISetText
    {
        public UscUninstall()
        {
            InitializeComponent();
            SetComponentsText();
        }

        public void SetComponentsText()
        {
            lblTitle.Text = Strings.titleUninstall;
            lblDescription.Text = Strings.descUninstall;
            Console.WriteLine("teste");
        }

        private void Uninstall()
        {
            FrmConfig.canClose = false;
            progressBar.Maximum = 2;
            progressBar.Value = 0;
            progressBar.Step = 1;

            //processo 1

            if (Directory.Exists(UseXML.directory))
            {
                string[] filesToDelete = Directory.GetFiles(UseXML.directory);

                foreach (string s in filesToDelete)
                    File.Delete(s);

                Directory.Delete(UseXML.directory);
            }
            progressBar.PerformStep();

            //processo 2
            ServiceController service = ServiceController.GetServices().FirstOrDefault(s => s.ServiceName == "8Bot");

            if (service != null)
            {
                string _8BotUninstaller = string.Format(@"{0}/8Bot.exe", LocalObserver.GetDirectoryOfApp());
                try
                {
                    if (service.CanStop)
                        service.Stop();
                    ServicesOptions.UninstallService(_8BotUninstaller);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            progressBar.PerformStep();
            FrmConfig.canClose = true;
            InvokeFinally();
        }

        private void InvokeFinally()
        {
            Parent.Controls.Add(new UscFinally(Strings.descFinally2));
            Parent.Controls.Remove(this);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var m = MessageBox.Show(Strings.descWarning, Strings.titleWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (m == DialogResult.Yes)
                Uninstall();
            else if (m == DialogResult.No)
            {
                Parent.Controls.Add(new UscWelcome());
                Parent.Controls.Remove(this);
            }
        }
    }
}
