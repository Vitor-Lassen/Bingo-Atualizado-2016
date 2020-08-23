namespace Bingo
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.BtnNumeros = new System.Windows.Forms.Button();
            this.pictureBoxBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNumeros
            // 
            this.BtnNumeros.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnNumeros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNumeros.Location = new System.Drawing.Point(12, 107);
            this.BtnNumeros.Name = "BtnNumeros";
            this.BtnNumeros.Size = new System.Drawing.Size(391, 47);
            this.BtnNumeros.TabIndex = 1;
            this.BtnNumeros.Text = "Sorteio";
            this.BtnNumeros.UseVisualStyleBackColor = false;
            this.BtnNumeros.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // pictureBoxBG
            // 
            this.pictureBoxBG.Image = global::Bingo.Properties.Resources.Bg;
            this.pictureBoxBG.Location = new System.Drawing.Point(-6, -88);
            this.pictureBoxBG.Name = "pictureBoxBG";
            this.pictureBoxBG.Size = new System.Drawing.Size(422, 316);
            this.pictureBoxBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBG.TabIndex = 2;
            this.pictureBoxBG.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 170);
            this.Controls.Add(this.BtnNumeros);
            this.Controls.Add(this.pictureBoxBG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bingo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNumeros;
        private System.Windows.Forms.PictureBox pictureBoxBG;

    }
}

