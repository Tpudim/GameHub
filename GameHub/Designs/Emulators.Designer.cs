
namespace GameHub.Designs
{
    partial class Emulators
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
            this.EmulatorImage = new System.Windows.Forms.PictureBox();
            this.TittleText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmulatorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // EmulatorImage
            // 
            this.EmulatorImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.EmulatorImage.Location = new System.Drawing.Point(3, 3);
            this.EmulatorImage.Name = "EmulatorImage";
            this.EmulatorImage.Size = new System.Drawing.Size(75, 71);
            this.EmulatorImage.TabIndex = 0;
            this.EmulatorImage.TabStop = false;
            this.EmulatorImage.Click += new System.EventHandler(this.EmulatorImage_Click);
            this.EmulatorImage.MouseEnter += new System.EventHandler(this.Emulators_MouseEnter);
            this.EmulatorImage.MouseLeave += new System.EventHandler(this.Emulators_MouseLeave);
            // 
            // TittleText
            // 
            this.TittleText.AutoSize = true;
            this.TittleText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TittleText.Location = new System.Drawing.Point(84, 27);
            this.TittleText.Name = "TittleText";
            this.TittleText.Size = new System.Drawing.Size(111, 21);
            this.TittleText.TabIndex = 1;
            this.TittleText.Text = "Emulator Tittle";
            this.TittleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TittleText.Click += new System.EventHandler(this.TittleText_Click);
            this.TittleText.MouseEnter += new System.EventHandler(this.Emulators_MouseEnter);
            this.TittleText.MouseLeave += new System.EventHandler(this.Emulators_MouseLeave);
            // 
            // Emulators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.TittleText);
            this.Controls.Add(this.EmulatorImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Emulators";
            this.Size = new System.Drawing.Size(224, 78);
            this.Load += new System.EventHandler(this.Emulators_Load);
            this.Click += new System.EventHandler(this.Emulators_Click);
            this.MouseEnter += new System.EventHandler(this.Emulators_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Emulators_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.EmulatorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox EmulatorImage;
        public System.Windows.Forms.Label TittleText;
    }
}
