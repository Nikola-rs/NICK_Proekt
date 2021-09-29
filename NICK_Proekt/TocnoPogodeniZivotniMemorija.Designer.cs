
namespace NICK_Proekt
{
    partial class TocnoPogodeniSiteZivotniMemorija
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIgrajPovtorno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNazadIzborIgra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NICK_Proekt.Properties.Resources.confetti;
            this.pictureBox1.Location = new System.Drawing.Point(91, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(973, 439);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnIgrajPovtorno
            // 
            this.btnIgrajPovtorno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.btnIgrajPovtorno.Location = new System.Drawing.Point(508, 511);
            this.btnIgrajPovtorno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIgrajPovtorno.Name = "btnIgrajPovtorno";
            this.btnIgrajPovtorno.Size = new System.Drawing.Size(164, 28);
            this.btnIgrajPovtorno.TabIndex = 7;
            this.btnIgrajPovtorno.Text = "Играј повторно";
            this.btnIgrajPovtorno.UseVisualStyleBackColor = false;
            this.btnIgrajPovtorno.Click += new System.EventHandler(this.btnIgrajPovtorno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 476);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Браво! Ги погоди сите сликички!";
            // 
            // btnNazadIzborIgra
            // 
            this.btnNazadIzborIgra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(245)))), ((int)(((byte)(28)))));
            this.btnNazadIzborIgra.Location = new System.Drawing.Point(3, 511);
            this.btnNazadIzborIgra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNazadIzborIgra.Name = "btnNazadIzborIgra";
            this.btnNazadIzborIgra.Size = new System.Drawing.Size(132, 28);
            this.btnNazadIzborIgra.TabIndex = 8;
            this.btnNazadIzborIgra.Text = "Назад до игрите";
            this.btnNazadIzborIgra.UseVisualStyleBackColor = false;
            this.btnNazadIzborIgra.Click += new System.EventHandler(this.btnNazadIzborIgra_Click);
            // 
            // TocnoPogodeniSiteZivotniMemorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NICK_Proekt.Properties.Resources.pozadina222;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNazadIzborIgra);
            this.Controls.Add(this.btnIgrajPovtorno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TocnoPogodeniSiteZivotniMemorija";
            this.Text = "TocnoPogodeniSiteZivotniZaGame2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIgrajPovtorno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNazadIzborIgra;
    }
}