namespace _8Bot_Configuration.View
{
    partial class UscInstall
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnEtc = new System.Windows.Forms.Button();
            this.lblExplain = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(7, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(404, 45);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "title";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(9, 47);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(402, 53);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "welcome";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(12, 118);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(337, 22);
            this.txtFolder.TabIndex = 6;
            // 
            // btnEtc
            // 
            this.btnEtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtc.Location = new System.Drawing.Point(356, 118);
            this.btnEtc.Name = "btnEtc";
            this.btnEtc.Size = new System.Drawing.Size(67, 23);
            this.btnEtc.TabIndex = 7;
            this.btnEtc.Text = ". . .";
            this.btnEtc.UseVisualStyleBackColor = true;
            this.btnEtc.Click += new System.EventHandler(this.BtnEtc_Click);
            // 
            // lblExplain
            // 
            this.lblExplain.Location = new System.Drawing.Point(9, 186);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(402, 121);
            this.lblExplain.TabIndex = 8;
            this.lblExplain.Text = "explain";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Location = new System.Drawing.Point(236, 432);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 27);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.AutoSize = true;
            this.btnInstall.Location = new System.Drawing.Point(349, 432);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(79, 27);
            this.btnInstall.TabIndex = 9;
            this.btnInstall.Text = "Instalar";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.BtnInstall_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 310);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(416, 23);
            this.progressBar.TabIndex = 11;
            this.progressBar.Visible = false;
            // 
            // UscInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.lblExplain);
            this.Controls.Add(this.btnEtc);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Location = new System.Drawing.Point(246, 12);
            this.Name = "UscInstall";
            this.Size = new System.Drawing.Size(441, 462);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnEtc;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}
