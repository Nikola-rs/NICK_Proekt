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
            this.btnExit = new System.Windows.Forms.Button();
            this.pbGame1Failed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame1Failed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ова не е точното животно!\r\n";
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTryAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.btnTryAgain.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryAgain.Location = new System.Drawing.Point(339, 262);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(143, 25);
            this.btnTryAgain.TabIndex = 1;
            this.btnTryAgain.Text = "Обиди се повторно";
            this.btnTryAgain.UseVisualStyleBackColor = false;
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // btnBackToGames
            // 
            this.btnBackToGames.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBackToGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.btnBackToGames.Location = new System.Drawing.Point(323, 293);
            this.btnBackToGames.Name = "btnBackToGames";
            this.btnBackToGames.Size = new System.Drawing.Size(171, 25);
            this.btnBackToGames.TabIndex = 2;
            this.btnBackToGames.Text = "Продолжи кон друга игра";
            this.btnBackToGames.UseVisualStyleBackColor = false;
            this.btnBackToGames.Click += new System.EventHandler(this.btnBackToGames_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::NICK_Proekt.Properties.Resources.wrongAnswerEmoji1;
            this.pictureBox1.Location = new System.Drawing.Point(323, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(633, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 30);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Исклучи ја играта";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbGame1Failed
            // 
            this.pbGame1Failed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbGame1Failed.BackColor = System.Drawing.Color.Transparent;
            this.pbGame1Failed.Image = global::NICK_Proekt.Properties.Resources.speaker;
            this.pbGame1Failed.Location = new System.Drawing.Point(261, 29);
            this.pbGame1Failed.Name = "pbGame1Failed";
            this.pbGame1Failed.Size = new System.Drawing.Size(33, 37);
            this.pbGame1Failed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGame1Failed.TabIndex = 28;
            this.pbGame1Failed.TabStop = false;
            this.pbGame1Failed.Click += new System.EventHandler(this.pbGame1Failed_Click);
            // 
            // GreskaPogodenoZivotno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NICK_Proekt.Properties.Resources.pozadina222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 456);
            this.Controls.Add(this.pbGame1Failed);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBackToGames);
            this.Controls.Add(this.btnTryAgain);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GreskaPogodenoZivotno";
            this.Text = "GreskaPogodenoZivotno";
            this.Load += new System.EventHandler(this.GreskaPogodenoZivotno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame1Failed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTryAgain;
        private System.Windows.Forms.Button btnBackToGames;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbGame1Failed;
    }
}