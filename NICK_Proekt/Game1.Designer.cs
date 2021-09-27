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
            this.picDog = new System.Windows.Forms.PictureBox();
            this.picParrot = new System.Windows.Forms.PictureBox();
            this.btnBackOnGames = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbGame1Info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParrot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame1Info)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.lblNaslov.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(327, 101);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(178, 54);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "МОЖЕШ ЛИ \r\nДА ГО ПРЕПОЗНАЕШ \r\nКУЧЕТО?";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNaslov.Click += new System.EventHandler(this.label1_Click);
            // 
            // picDog
            // 
            this.picDog.BackColor = System.Drawing.Color.Transparent;
            this.picDog.Image = global::NICK_Proekt.Properties.Resources.dogg;
            this.picDog.Location = new System.Drawing.Point(67, 227);
            this.picDog.Name = "picDog";
            this.picDog.Size = new System.Drawing.Size(117, 124);
            this.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDog.TabIndex = 2;
            this.picDog.TabStop = false;
            this.picDog.Click += new System.EventHandler(this.picDog_Click);
            // 
            // picParrot
            // 
            this.picParrot.BackColor = System.Drawing.Color.Transparent;
            this.picParrot.Image = global::NICK_Proekt.Properties.Resources.parrott;
            this.picParrot.Location = new System.Drawing.Point(610, 227);
            this.picParrot.Name = "picParrot";
            this.picParrot.Size = new System.Drawing.Size(117, 124);
            this.picParrot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picParrot.TabIndex = 3;
            this.picParrot.TabStop = false;
            this.picParrot.Click += new System.EventHandler(this.picParrot_Click);
            // 
            // btnBackOnGames
            // 
            this.btnBackOnGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.btnBackOnGames.Location = new System.Drawing.Point(3, 2);
            this.btnBackOnGames.Name = "btnBackOnGames";
            this.btnBackOnGames.Size = new System.Drawing.Size(52, 33);
            this.btnBackOnGames.TabIndex = 4;
            this.btnBackOnGames.Text = "Назад";
            this.btnBackOnGames.UseVisualStyleBackColor = false;
            this.btnBackOnGames.Click += new System.EventHandler(this.btnBackOnGames_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::NICK_Proekt.Properties.Resources.blob;
            this.pictureBox6.Location = new System.Drawing.Point(190, 33);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(414, 393);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // picCat
            // 
            this.picCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.picCat.Image = global::NICK_Proekt.Properties.Resources.catt;
            this.picCat.Location = new System.Drawing.Point(357, 227);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(117, 124);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCat.TabIndex = 1;
            this.picCat.TabStop = false;
            this.picCat.Click += new System.EventHandler(this.picCat_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(634, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 30);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Исклучи ја играта";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbGame1Info
            // 
            this.pbGame1Info.BackColor = System.Drawing.Color.Transparent;
            this.pbGame1Info.Image = global::NICK_Proekt.Properties.Resources.speaker;
            this.pbGame1Info.Location = new System.Drawing.Point(208, 45);
            this.pbGame1Info.Name = "pbGame1Info";
            this.pbGame1Info.Size = new System.Drawing.Size(33, 37);
            this.pbGame1Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGame1Info.TabIndex = 28;
            this.pbGame1Info.TabStop = false;
            this.pbGame1Info.Click += new System.EventHandler(this.pbGame1Info_Click);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NICK_Proekt.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(770, 456);
            this.Controls.Add(this.pbGame1Info);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackOnGames);
            this.Controls.Add(this.picParrot);
            this.Controls.Add(this.picDog);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.pictureBox6);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Game1";
            this.Text = "Game1";
            this.Load += new System.EventHandler(this.Game1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParrot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame1Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.PictureBox picDog;
        private System.Windows.Forms.PictureBox picParrot;
        private System.Windows.Forms.Button btnBackOnGames;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbGame1Info;
    }
}