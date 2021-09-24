namespace NICK_Proekt
{
    partial class GreskaPogodenoZivotno
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTryAgain = new System.Windows.Forms.Button();
            this.btnBackToGames = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ова не е точното животно!\r\n";
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.btnTryAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryAgain.Location = new System.Drawing.Point(393, 217);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(123, 23);
            this.btnTryAgain.TabIndex = 1;
            this.btnTryAgain.Text = "Обиди се повторно";
            this.btnTryAgain.UseVisualStyleBackColor = false;
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // btnBackToGames
            // 
            this.btnBackToGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.btnBackToGames.Location = new System.Drawing.Point(378, 246);
            this.btnBackToGames.Name = "btnBackToGames";
            this.btnBackToGames.Size = new System.Drawing.Size(147, 23);
            this.btnBackToGames.TabIndex = 2;
            this.btnBackToGames.Text = "Продолжи кон друга игра";
            this.btnBackToGames.UseVisualStyleBackColor = false;
            this.btnBackToGames.Click += new System.EventHandler(this.btnBackToGames_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.pictureBox1.Image = global::NICK_Proekt.Properties.Resources.wrongAnswerEmoji;
            this.pictureBox1.Location = new System.Drawing.Point(394, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // GreskaPogodenoZivotno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NICK_Proekt.Properties.Resources.pozadina222;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBackToGames);
            this.Controls.Add(this.btnTryAgain);
            this.Controls.Add(this.label1);
            this.Name = "GreskaPogodenoZivotno";
            this.Text = "GreskaPogodenoZivotno";
            this.Load += new System.EventHandler(this.GreskaPogodenoZivotno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTryAgain;
        private System.Windows.Forms.Button btnBackToGames;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}