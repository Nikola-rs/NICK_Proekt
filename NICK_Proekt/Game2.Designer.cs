namespace NICK_Proekt
{
    partial class Game2
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
            this.pbDog = new System.Windows.Forms.PictureBox();
            this.pbCat = new System.Windows.Forms.PictureBox();
            this.pbParrot = new System.Windows.Forms.PictureBox();
            this.pbMouse = new System.Windows.Forms.PictureBox();
            this.lbforDog = new System.Windows.Forms.ListBox();
            this.lbForParrot = new System.Windows.Forms.ListBox();
            this.lbForMouse = new System.Windows.Forms.ListBox();
            this.lbForCat = new System.Windows.Forms.ListBox();
            this.lblAllCorrect = new System.Windows.Forms.Label();
            this.lblDog = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblParrot = new System.Windows.Forms.Label();
            this.lblMouse = new System.Windows.Forms.Label();
            this.btnBackOnGames = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParrot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDog
            // 
            this.pbDog.Image = global::NICK_Proekt.Properties.Resources.dogg;
            this.pbDog.Location = new System.Drawing.Point(28, 62);
            this.pbDog.Name = "pbDog";
            this.pbDog.Size = new System.Drawing.Size(102, 113);
            this.pbDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog.TabIndex = 5;
            this.pbDog.TabStop = false;
            // 
            // pbCat
            // 
            this.pbCat.Image = global::NICK_Proekt.Properties.Resources.catt;
            this.pbCat.Location = new System.Drawing.Point(569, 62);
            this.pbCat.Name = "pbCat";
            this.pbCat.Size = new System.Drawing.Size(102, 113);
            this.pbCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCat.TabIndex = 6;
            this.pbCat.TabStop = false;
            // 
            // pbParrot
            // 
            this.pbParrot.Image = global::NICK_Proekt.Properties.Resources.parrott;
            this.pbParrot.Location = new System.Drawing.Point(28, 238);
            this.pbParrot.Name = "pbParrot";
            this.pbParrot.Size = new System.Drawing.Size(102, 112);
            this.pbParrot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbParrot.TabIndex = 7;
            this.pbParrot.TabStop = false;
            // 
            // pbMouse
            // 
            this.pbMouse.Image = global::NICK_Proekt.Properties.Resources.mouse;
            this.pbMouse.Location = new System.Drawing.Point(569, 238);
            this.pbMouse.Name = "pbMouse";
            this.pbMouse.Size = new System.Drawing.Size(102, 112);
            this.pbMouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMouse.TabIndex = 8;
            this.pbMouse.TabStop = false;
            // 
            // lbforDog
            // 
            this.lbforDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.lbforDog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbforDog.FormattingEnabled = true;
            this.lbforDog.ItemHeight = 14;
            this.lbforDog.Items.AddRange(new object[] {
            "Куче",
            "Маче",
            "Папагал",
            "Глувче"});
            this.lbforDog.Location = new System.Drawing.Point(136, 96);
            this.lbforDog.Name = "lbforDog";
            this.lbforDog.Size = new System.Drawing.Size(87, 56);
            this.lbforDog.TabIndex = 9;
            this.lbforDog.SelectedIndexChanged += new System.EventHandler(this.lbforDog_SelectedIndexChanged);
            // 
            // lbForParrot
            // 
            this.lbForParrot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.lbForParrot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbForParrot.FormattingEnabled = true;
            this.lbForParrot.ItemHeight = 14;
            this.lbForParrot.Items.AddRange(new object[] {
            "Куче",
            "Маче",
            "Папагал",
            "Глувче"});
            this.lbForParrot.Location = new System.Drawing.Point(136, 268);
            this.lbForParrot.Name = "lbForParrot";
            this.lbForParrot.Size = new System.Drawing.Size(87, 56);
            this.lbForParrot.TabIndex = 15;
            this.lbForParrot.SelectedIndexChanged += new System.EventHandler(this.lbForParrot_SelectedIndexChanged);
            // 
            // lbForMouse
            // 
            this.lbForMouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.lbForMouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbForMouse.FormattingEnabled = true;
            this.lbForMouse.ItemHeight = 14;
            this.lbForMouse.Items.AddRange(new object[] {
            "Куче",
            "Маче",
            "Папагал",
            "Глувче"});
            this.lbForMouse.Location = new System.Drawing.Point(677, 268);
            this.lbForMouse.Name = "lbForMouse";
            this.lbForMouse.Size = new System.Drawing.Size(87, 56);
            this.lbForMouse.TabIndex = 16;
            this.lbForMouse.SelectedIndexChanged += new System.EventHandler(this.lbForMouse_SelectedIndexChanged);
            // 
            // lbForCat
            // 
            this.lbForCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.lbForCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbForCat.FormattingEnabled = true;
            this.lbForCat.ItemHeight = 14;
            this.lbForCat.Items.AddRange(new object[] {
            "Куче",
            "Маче",
            "Папагал",
            "Глувче"});
            this.lbForCat.Location = new System.Drawing.Point(677, 96);
            this.lbForCat.Name = "lbForCat";
            this.lbForCat.Size = new System.Drawing.Size(87, 56);
            this.lbForCat.TabIndex = 17;
            this.lbForCat.SelectedIndexChanged += new System.EventHandler(this.lbForCat_SelectedIndexChanged);
            // 
            // lblAllCorrect
            // 
            this.lblAllCorrect.AutoSize = true;
            this.lblAllCorrect.Location = new System.Drawing.Point(334, 411);
            this.lblAllCorrect.Name = "lblAllCorrect";
            this.lblAllCorrect.Size = new System.Drawing.Size(0, 14);
            this.lblAllCorrect.TabIndex = 18;
            // 
            // lblDog
            // 
            this.lblDog.AutoSize = true;
            this.lblDog.Location = new System.Drawing.Point(26, 178);
            this.lblDog.Name = "lblDog";
            this.lblDog.Size = new System.Drawing.Size(28, 14);
            this.lblDog.TabIndex = 19;
            this.lblDog.Text = ";b;";
            this.lblDog.Visible = false;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(569, 178);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(49, 14);
            this.lblCat.TabIndex = 20;
            this.lblCat.Text = "label2";
            this.lblCat.Visible = false;
            // 
            // lblParrot
            // 
            this.lblParrot.AutoSize = true;
            this.lblParrot.Location = new System.Drawing.Point(26, 353);
            this.lblParrot.Name = "lblParrot";
            this.lblParrot.Size = new System.Drawing.Size(49, 14);
            this.lblParrot.TabIndex = 21;
            this.lblParrot.Text = "label3";
            this.lblParrot.Visible = false;
            // 
            // lblMouse
            // 
            this.lblMouse.AutoSize = true;
            this.lblMouse.Location = new System.Drawing.Point(569, 353);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(49, 14);
            this.lblMouse.TabIndex = 22;
            this.lblMouse.Text = "label4";
            this.lblMouse.Visible = false;
            // 
            // btnBackOnGames
            // 
            this.btnBackOnGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.btnBackOnGames.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackOnGames.Location = new System.Drawing.Point(2, 5);
            this.btnBackOnGames.Name = "btnBackOnGames";
            this.btnBackOnGames.Size = new System.Drawing.Size(52, 33);
            this.btnBackOnGames.TabIndex = 23;
            this.btnBackOnGames.Text = "Назад";
            this.btnBackOnGames.UseVisualStyleBackColor = false;
            this.btnBackOnGames.Click += new System.EventHandler(this.btnBackOnGames_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::NICK_Proekt.Properties.Resources.blob;
            this.pictureBox6.Location = new System.Drawing.Point(189, 41);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(414, 393);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(321, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 88);
            this.label1.TabIndex = 25;
            this.label1.Text = "ДАЛИ МОЖЕШ ДА ГИ\r\nПРЕПОЗНАЕШ\r\nЖИВОТНИТЕ\r\nСО НИВНОТО ИМЕ?\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(630, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 30);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Исклучи ја играта";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NICK_Proekt.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(770, 456);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackOnGames);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.lblParrot);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblDog);
            this.Controls.Add(this.lblAllCorrect);
            this.Controls.Add(this.lbForCat);
            this.Controls.Add(this.lbForMouse);
            this.Controls.Add(this.lbForParrot);
            this.Controls.Add(this.lbforDog);
            this.Controls.Add(this.pbMouse);
            this.Controls.Add(this.pbParrot);
            this.Controls.Add(this.pbCat);
            this.Controls.Add(this.pbDog);
            this.Controls.Add(this.pictureBox6);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Game2";
            this.Text = "Game2";
            this.Load += new System.EventHandler(this.Game2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParrot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbDog;
        private System.Windows.Forms.PictureBox pbCat;
        private System.Windows.Forms.PictureBox pbParrot;
        private System.Windows.Forms.PictureBox pbMouse;
        private System.Windows.Forms.ListBox lbforDog;
        private System.Windows.Forms.ListBox lbForParrot;
        private System.Windows.Forms.ListBox lbForMouse;
        private System.Windows.Forms.ListBox lbForCat;
        private System.Windows.Forms.Label lblAllCorrect;
        private System.Windows.Forms.Label lblDog;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblParrot;
        private System.Windows.Forms.Label lblMouse;
        private System.Windows.Forms.Button btnBackOnGames;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}