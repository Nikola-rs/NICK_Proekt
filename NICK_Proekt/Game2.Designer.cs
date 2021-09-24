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
            this.lblNaslov = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParrot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMouse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(204, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(358, 16);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "ДАЛИ МОЖЕШ ДА ГИ ПОВРЗИШ ЖИВОТНИТЕ СО НИВНОТО ИМЕ?";
            // 
            // pbDog
            // 
            this.pbDog.Image = global::NICK_Proekt.Properties.Resources.dogg;
            this.pbDog.Location = new System.Drawing.Point(183, 68);
            this.pbDog.Name = "pbDog";
            this.pbDog.Size = new System.Drawing.Size(100, 94);
            this.pbDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog.TabIndex = 5;
            this.pbDog.TabStop = false;
            // 
            // pbCat
            // 
            this.pbCat.Image = global::NICK_Proekt.Properties.Resources.catt;
            this.pbCat.Location = new System.Drawing.Point(477, 68);
            this.pbCat.Name = "pbCat";
            this.pbCat.Size = new System.Drawing.Size(100, 94);
            this.pbCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCat.TabIndex = 6;
            this.pbCat.TabStop = false;
            // 
            // pbParrot
            // 
            this.pbParrot.Image = global::NICK_Proekt.Properties.Resources.parrott;
            this.pbParrot.Location = new System.Drawing.Point(183, 231);
            this.pbParrot.Name = "pbParrot";
            this.pbParrot.Size = new System.Drawing.Size(100, 94);
            this.pbParrot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbParrot.TabIndex = 7;
            this.pbParrot.TabStop = false;
            // 
            // pbMouse
            // 
            this.pbMouse.Image = global::NICK_Proekt.Properties.Resources.mouse;
            this.pbMouse.Location = new System.Drawing.Point(477, 231);
            this.pbMouse.Name = "pbMouse";
            this.pbMouse.Size = new System.Drawing.Size(100, 94);
            this.pbMouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMouse.TabIndex = 8;
            this.pbMouse.TabStop = false;
            // 
            // lbforDog
            // 
            this.lbforDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.lbforDog.FormattingEnabled = true;
            this.lbforDog.Items.AddRange(new object[] {
            "Куче",
            "Маче",
            "Папагал",
            "Глувче"});
            this.lbforDog.Location = new System.Drawing.Point(289, 89);
            this.lbforDog.Name = "lbforDog";
            this.lbforDog.Size = new System.Drawing.Size(120, 56);
            this.lbforDog.TabIndex = 9;
            this.lbforDog.SelectedIndexChanged += new System.EventHandler(this.lbforDog_SelectedIndexChanged);
            // 
            // lbForParrot
            // 
            this.lbForParrot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.lbForParrot.FormattingEnabled = true;
            this.lbForParrot.Items.AddRange(new object[] {
            "Куче",
            "Маче",
            "Папагал",
            "Глувче"});
            this.lbForParrot.Location = new System.Drawing.Point(289, 249);
            this.lbForParrot.Name = "lbForParrot";
            this.lbForParrot.Size = new System.Drawing.Size(120, 56);
            this.lbForParrot.TabIndex = 15;
            this.lbForParrot.SelectedIndexChanged += new System.EventHandler(this.lbForParrot_SelectedIndexChanged);
            // 
            // lbForMouse
            // 
            this.lbForMouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.lbForMouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbForMouse.FormattingEnabled = true;
            this.lbForMouse.Items.AddRange(new object[] {
            "Куче",
            "Маче",
            "Папагал",
            "Глувче"});
            this.lbForMouse.Location = new System.Drawing.Point(583, 249);
            this.lbForMouse.Name = "lbForMouse";
            this.lbForMouse.Size = new System.Drawing.Size(120, 52);
            this.lbForMouse.TabIndex = 16;
            this.lbForMouse.SelectedIndexChanged += new System.EventHandler(this.lbForMouse_SelectedIndexChanged);
            // 
            // lbForCat
            // 
            this.lbForCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.lbForCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbForCat.FormattingEnabled = true;
            this.lbForCat.Items.AddRange(new object[] {
            "Куче",
            "Маче",
            "Папагал",
            "Глувче"});
            this.lbForCat.Location = new System.Drawing.Point(583, 89);
            this.lbForCat.Name = "lbForCat";
            this.lbForCat.Size = new System.Drawing.Size(120, 54);
            this.lbForCat.TabIndex = 17;
            this.lbForCat.SelectedIndexChanged += new System.EventHandler(this.lbForCat_SelectedIndexChanged);
            // 
            // lblAllCorrect
            // 
            this.lblAllCorrect.AutoSize = true;
            this.lblAllCorrect.Location = new System.Drawing.Point(286, 382);
            this.lblAllCorrect.Name = "lblAllCorrect";
            this.lblAllCorrect.Size = new System.Drawing.Size(0, 13);
            this.lblAllCorrect.TabIndex = 18;
            // 
            // lblDog
            // 
            this.lblDog.AutoSize = true;
            this.lblDog.Location = new System.Drawing.Point(180, 165);
            this.lblDog.Name = "lblDog";
            this.lblDog.Size = new System.Drawing.Size(19, 13);
            this.lblDog.TabIndex = 19;
            this.lblDog.Text = ";b;";
            this.lblDog.Visible = false;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(474, 165);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(35, 13);
            this.lblCat.TabIndex = 20;
            this.lblCat.Text = "label2";
            this.lblCat.Visible = false;
            // 
            // lblParrot
            // 
            this.lblParrot.AutoSize = true;
            this.lblParrot.Location = new System.Drawing.Point(180, 328);
            this.lblParrot.Name = "lblParrot";
            this.lblParrot.Size = new System.Drawing.Size(35, 13);
            this.lblParrot.TabIndex = 21;
            this.lblParrot.Text = "label3";
            this.lblParrot.Visible = false;
            // 
            // lblMouse
            // 
            this.lblMouse.AutoSize = true;
            this.lblMouse.Location = new System.Drawing.Point(474, 328);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(35, 13);
            this.lblMouse.TabIndex = 22;
            this.lblMouse.Text = "label4";
            this.lblMouse.Visible = false;
            // 
            // btnBackOnGames
            // 
            this.btnBackOnGames.Location = new System.Drawing.Point(12, 12);
            this.btnBackOnGames.Name = "btnBackOnGames";
            this.btnBackOnGames.Size = new System.Drawing.Size(75, 23);
            this.btnBackOnGames.TabIndex = 23;
            this.btnBackOnGames.Text = "Назад";
            this.btnBackOnGames.UseVisualStyleBackColor = true;
            this.btnBackOnGames.Click += new System.EventHandler(this.btnBackOnGames_Click);
            // 
            // Game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NICK_Proekt.Properties.Resources.pozadina222;
            this.ClientSize = new System.Drawing.Size(800, 481);
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
            this.Controls.Add(this.lblNaslov);
            this.Name = "Game2";
            this.Text = "Game2";
            this.Load += new System.EventHandler(this.Game2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParrot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
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
    }
}