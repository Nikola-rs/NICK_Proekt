namespace NICK_Proekt
{
    partial class TocnoPogodenoZivotno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNazadIzborIgra = new System.Windows.Forms.Button();
            this.btnIgrajPovtorno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NICK_Proekt.Properties.Resources.confetti;
            this.pictureBox1.Location = new System.Drawing.Point(72, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(836, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Браво! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тоа е кучето ";
            // 
            // btnNazadIzborIgra
            // 
            this.btnNazadIzborIgra.Location = new System.Drawing.Point(72, 415);
            this.btnNazadIzborIgra.Name = "btnNazadIzborIgra";
            this.btnNazadIzborIgra.Size = new System.Drawing.Size(93, 23);
            this.btnNazadIzborIgra.TabIndex = 3;
            this.btnNazadIzborIgra.Text = "Назад";
            this.btnNazadIzborIgra.UseVisualStyleBackColor = true;
            // 
            // btnIgrajPovtorno
            // 
            this.btnIgrajPovtorno.Location = new System.Drawing.Point(452, 390);
            this.btnIgrajPovtorno.Name = "btnIgrajPovtorno";
            this.btnIgrajPovtorno.Size = new System.Drawing.Size(123, 23);
            this.btnIgrajPovtorno.TabIndex = 4;
            this.btnIgrajPovtorno.Text = "Играј повторно";
            this.btnIgrajPovtorno.UseVisualStyleBackColor = true;
            // 
            // TocnoPogodenoZivotno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NICK_Proekt.Properties.Resources.Pozadina2;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.btnIgrajPovtorno);
            this.Controls.Add(this.btnNazadIzborIgra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TocnoPogodenoZivotno";
            this.Text = "TocnoPogodenoZivotno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNazadIzborIgra;
        private System.Windows.Forms.Button btnIgrajPovtorno;
    }
}