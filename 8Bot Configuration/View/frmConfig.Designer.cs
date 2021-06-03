namespace _8Bot_Configuration
{
    partial class FrmConfig
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.img8bot = new System.Windows.Forms.PictureBox();
            this.lblWaterMark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img8bot)).BeginInit();
            this.SuspendLayout();
            // 
            // img8bot
            // 
            this.img8bot.Image = global::_8Bot_Configuration.Properties.Resources._8bot_form;
            this.img8bot.Location = new System.Drawing.Point(12, 12);
            this.img8bot.Name = "img8bot";
            this.img8bot.Size = new System.Drawing.Size(228, 462);
            this.img8bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img8bot.TabIndex = 0;
            this.img8bot.TabStop = false;
            // 
            // lblWaterMark
            // 
            this.lblWaterMark.BackColor = System.Drawing.Color.Transparent;
            this.lblWaterMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterMark.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWaterMark.Location = new System.Drawing.Point(12, 454);
            this.lblWaterMark.Name = "lblWaterMark";
            this.lblWaterMark.Size = new System.Drawing.Size(228, 23);
            this.lblWaterMark.TabIndex = 1;
            this.lblWaterMark.Text = "Made by: Enrisco";
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 482);
            this.Controls.Add(this.lblWaterMark);
            this.Controls.Add(this.img8bot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfig";
            ((System.ComponentModel.ISupportInitialize)(this.img8bot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img8bot;
        private System.Windows.Forms.Label lblWaterMark;
    }
}

