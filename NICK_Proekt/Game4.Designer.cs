
namespace NICK_Proekt
{
    partial class Game4
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
            this.cow = new System.Windows.Forms.PictureBox();
            this.chicken = new System.Windows.Forms.PictureBox();
            this.sheep = new System.Windows.Forms.PictureBox();
            this.horse = new System.Windows.Forms.PictureBox();
            this.cowLabel = new System.Windows.Forms.Label();
            this.chickenLabel = new System.Windows.Forms.Label();
            this.sheepLabel = new System.Windows.Forms.Label();
            this.horseLabel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBackOnGames = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.pbGame4Info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame4Info)).BeginInit();
            this.SuspendLayout();
            // 
            // cow
            // 
            this.cow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cow.BackColor = System.Drawing.Color.Transparent;
            this.cow.Image = global::NICK_Proekt.Properties.Resources.pngaaa_com_2808365;
            this.cow.Location = new System.Drawing.Point(408, 94);
            this.cow.Name = "cow";
            this.cow.Size = new System.Drawing.Size(100, 100);
            this.cow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cow.TabIndex = 0;
            this.cow.TabStop = false;
            this.cow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragImage_MouseDown);
            this.cow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragImage_MouseMove);
            // 
            // chicken
            // 
            this.chicken.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chicken.BackColor = System.Drawing.Color.Transparent;
            this.chicken.Image = global::NICK_Proekt.Properties.Resources.pngaaa_com_2238943;
            this.chicken.Location = new System.Drawing.Point(283, 227);
            this.chicken.Name = "chicken";
            this.chicken.Size = new System.Drawing.Size(100, 100);
            this.chicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chicken.TabIndex = 1;
            this.chicken.TabStop = false;
            this.chicken.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragImage_MouseDown);
            this.chicken.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragImage_MouseMove);
            // 
            // sheep
            // 
            this.sheep.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sheep.BackColor = System.Drawing.Color.Transparent;
            this.sheep.Image = global::NICK_Proekt.Properties.Resources.pngaaa_com_2517951;
            this.sheep.Location = new System.Drawing.Point(408, 227);
            this.sheep.Name = "sheep";
            this.sheep.Size = new System.Drawing.Size(100, 100);
            this.sheep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sheep.TabIndex = 2;
            this.sheep.TabStop = false;
            this.sheep.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragImage_MouseDown);
            this.sheep.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragImage_MouseMove);
            // 
            // horse
            // 
            this.horse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.horse.BackColor = System.Drawing.Color.Transparent;
            this.horse.Image = global::NICK_Proekt.Properties.Resources.pngaaa_com_1453472;
            this.horse.Location = new System.Drawing.Point(283, 94);
            this.horse.Name = "horse";
            this.horse.Size = new System.Drawing.Size(100, 100);
            this.horse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse.TabIndex = 3;
            this.horse.TabStop = false;
            this.horse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragImage_MouseDown);
            this.horse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragImage_MouseMove);
            // 
            // cowLabel
            // 
            this.cowLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cowLabel.AutoSize = true;
            this.cowLabel.BackColor = System.Drawing.Color.Transparent;
            this.cowLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cowLabel.Location = new System.Drawing.Point(12, 65);
            this.cowLabel.Name = "cowLabel";
            this.cowLabel.Size = new System.Drawing.Size(48, 16);
            this.cowLabel.TabIndex = 5;
            this.cowLabel.Text = "Крава";
            // 
            // chickenLabel
            // 
            this.chickenLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chickenLabel.AutoSize = true;
            this.chickenLabel.BackColor = System.Drawing.Color.Transparent;
            this.chickenLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chickenLabel.Location = new System.Drawing.Point(12, 329);
            this.chickenLabel.Name = "chickenLabel";
            this.chickenLabel.Size = new System.Drawing.Size(64, 16);
            this.chickenLabel.TabIndex = 6;
            this.chickenLabel.Text = "Кокошка";
            // 
            // sheepLabel
            // 
            this.sheepLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sheepLabel.AutoSize = true;
            this.sheepLabel.BackColor = System.Drawing.Color.Transparent;
            this.sheepLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheepLabel.Location = new System.Drawing.Point(718, 65);
            this.sheepLabel.Name = "sheepLabel";
            this.sheepLabel.Size = new System.Drawing.Size(40, 16);
            this.sheepLabel.TabIndex = 7;
            this.sheepLabel.Text = "Овца";
            // 
            // horseLabel
            // 
            this.horseLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.horseLabel.AutoSize = true;
            this.horseLabel.BackColor = System.Drawing.Color.Transparent;
            this.horseLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horseLabel.Location = new System.Drawing.Point(718, 329);
            this.horseLabel.Name = "horseLabel";
            this.horseLabel.Size = new System.Drawing.Size(32, 16);
            this.horseLabel.TabIndex = 8;
            this.horseLabel.Text = "Коњ";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(635, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 30);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Исклучи ја играта";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBackOnGames
            // 
            this.btnBackOnGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.btnBackOnGames.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackOnGames.Location = new System.Drawing.Point(-1, 0);
            this.btnBackOnGames.Name = "btnBackOnGames";
            this.btnBackOnGames.Size = new System.Drawing.Size(52, 33);
            this.btnBackOnGames.TabIndex = 28;
            this.btnBackOnGames.Text = "Назад";
            this.btnBackOnGames.UseVisualStyleBackColor = false;
            this.btnBackOnGames.Click += new System.EventHandler(this.btnBackOnGames_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(225, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(350, 31);
            this.lblNaslov.TabIndex = 29;
            this.lblNaslov.Text = "ПОВРЗУВАЊЕ НА ЖИВОТНИ";
            // 
            // pbGame4Info
            // 
            this.pbGame4Info.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbGame4Info.BackColor = System.Drawing.Color.Transparent;
            this.pbGame4Info.Image = global::NICK_Proekt.Properties.Resources.speaker;
            this.pbGame4Info.Location = new System.Drawing.Point(196, 3);
            this.pbGame4Info.Name = "pbGame4Info";
            this.pbGame4Info.Size = new System.Drawing.Size(33, 37);
            this.pbGame4Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGame4Info.TabIndex = 30;
            this.pbGame4Info.TabStop = false;
            this.pbGame4Info.Click += new System.EventHandler(this.pbGame4Info_Click);
            // 
            // Game4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NICK_Proekt.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(770, 456);
            this.Controls.Add(this.pbGame4Info);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnBackOnGames);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.horseLabel);
            this.Controls.Add(this.sheepLabel);
            this.Controls.Add(this.chickenLabel);
            this.Controls.Add(this.cowLabel);
            this.Controls.Add(this.horse);
            this.Controls.Add(this.sheep);
            this.Controls.Add(this.chicken);
            this.Controls.Add(this.cow);
            this.Name = "Game4";
            this.Text = "Game4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.cow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame4Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cow;
        private System.Windows.Forms.PictureBox chicken;
        private System.Windows.Forms.PictureBox sheep;
        private System.Windows.Forms.PictureBox horse;
        private System.Windows.Forms.Label cowLabel;
        private System.Windows.Forms.Label chickenLabel;
        private System.Windows.Forms.Label sheepLabel;
        private System.Windows.Forms.Label horseLabel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBackOnGames;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.PictureBox pbGame4Info;
    }
}