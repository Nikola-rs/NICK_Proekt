namespace NICK_Proekt
{
    partial class Game1
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.picDog = new System.Windows.Forms.PictureBox();
            this.picParrot = new System.Windows.Forms.PictureBox();
            this.btnBackOnGames = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParrot)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(275, 114);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(239, 13);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "МОЖЕШ ЛИ ДА ГО ПРЕПОЗНАЕШ КУЧЕТО?";
            this.lblNaslov.Click += new System.EventHandler(this.label1_Click);
            // 
            // picCat
            // 
            this.picCat.Image = global::NICK_Proekt.Properties.Resources.cat;
            this.picCat.Location = new System.Drawing.Point(346, 211);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(100, 115);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCat.TabIndex = 1;
            this.picCat.TabStop = false;
            this.picCat.Click += new System.EventHandler(this.picCat_Click);
            // 
            // picDog
            // 
            this.picDog.Image = global::NICK_Proekt.Properties.Resources.dog;
            this.picDog.Location = new System.Drawing.Point(104, 211);
            this.picDog.Name = "picDog";
            this.picDog.Size = new System.Drawing.Size(100, 115);
            this.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDog.TabIndex = 2;
            this.picDog.TabStop = false;
            this.picDog.Click += new System.EventHandler(this.picDog_Click);
            // 
            // picParrot
            // 
            this.picParrot.Image = global::NICK_Proekt.Properties.Resources.parrot;
            this.picParrot.Location = new System.Drawing.Point(582, 211);
            this.picParrot.Name = "picParrot";
            this.picParrot.Size = new System.Drawing.Size(100, 115);
            this.picParrot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picParrot.TabIndex = 3;
            this.picParrot.TabStop = false;
            this.picParrot.Click += new System.EventHandler(this.picParrot_Click);
            // 
            // btnBackOnGames
            // 
            this.btnBackOnGames.Location = new System.Drawing.Point(25, 12);
            this.btnBackOnGames.Name = "btnBackOnGames";
            this.btnBackOnGames.Size = new System.Drawing.Size(75, 23);
            this.btnBackOnGames.TabIndex = 4;
            this.btnBackOnGames.Text = "Назад";
            this.btnBackOnGames.UseVisualStyleBackColor = true;
            this.btnBackOnGames.Click += new System.EventHandler(this.btnBackOnGames_Click);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NICK_Proekt.Properties.Resources.Pozadina1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackOnGames);
            this.Controls.Add(this.picParrot);
            this.Controls.Add(this.picDog);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.lblNaslov);
            this.Name = "Game1";
            this.Text = "Game1";
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParrot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.PictureBox picDog;
        private System.Windows.Forms.PictureBox picParrot;
        private System.Windows.Forms.Button btnBackOnGames;
    }
}