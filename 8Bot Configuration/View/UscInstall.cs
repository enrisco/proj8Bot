using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.IO;
using System.Windows.Forms;
using _8Bot_Configuration.Model;
using _8Bot_Configuration.Controller;

namespace _8Bot_Configuration.View
{
    public partial class UscInstall : UserControl, ISetText
    {
        public UscInstall()
        {
            InitializeComponent();
            SetComponentsText();
        }

        public void SetComponentsText()
        {
            txtFolder.Text = @"C:\Program Files\Rockstar Games\Grand Theft Auto San Andreas";

            lblTitle.Text = Strings.titleInstall;
            lblDescription.Text = Strings.descInstall;
            lblExplain.Text = Strings.descExplain;
            btnBack.Text = Strings._btnBack;
            btnInstall.Text = Strings._btnInstall;
        }

        private void BtnEtc_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(new UscWelcome());
            Parent.Controls.Remove(this);
        }

        private void BtnInstall_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(txtFolder.Text))
            {
                progressBar.Visible = true;
                btnBack.Enabled = false;
                btnInstall.Enabled = false;
                Install();
            }
            else
            {
                var dialog = MessageBox.Show(Strings.descError, Strings.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(dialog == DialogResult.OK)
                {
                    Parent.Controls.Add(new UscInstall());
                    Parent.Controls.Remove(this);
                }
            }
        }

        private void Install()
        {
            FrmConfig.canClose = false;
            progressBar.Maximum = 2;
            progressBar.Value = 0;
            progressBar.Step = 1;

            Settings settings = new Settings()
            {
                name = "gta_files",
                path = txtFolder.Text
            };

            //processo 1
            if (!FrmConfig.isNotfirstTime)
            {
                UseXML.CreateDatabase("Settings");
                Crud.Create(settings);
            }
            else
            {
                Crud.Update(settings);
            }
            progressBar.PerformStep();

            //processo 2
            ServiceController service = ServiceController.GetServices().FirstOrDefault(s => s.ServiceName == "8Bot");
            
            if (service == null)
            {
                string _8BotInstaller = string.Format(@"{0}/8Bot.exe", LocalObserver.GetDirectoryOfApp());
                try
                {
                    Services.InstallService(_8BotInstaller);
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
            Parent.Controls.Add(new UscFinally(Strings.descFinally1));
            Parent.Controls.Remove(this);
        }
    }
}
