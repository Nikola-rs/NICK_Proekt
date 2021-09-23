namespace NICK_Proekt
{
    partial class Informativna_stranica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informativna_stranica));
            this.lblInformacii = new System.Windows.Forms.Label();
            this.btnGame1 = new System.Windows.Forms.Button();
            this.btnGame2 = new System.Windows.Forms.Button();
            this.btnGame3 = new System.Windows.Forms.Button();
            this.btnLearnAnimals = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInformacii
            // 
            this.lblInformacii.AutoSize = true;
            this.lblInformacii.Location = new System.Drawing.Point(357, 9);
            this.lblInformacii.Name = "lblInformacii";
            this.lblInformacii.Size = new System.Drawing.Size(125, 13);
            this.lblInformacii.TabIndex = 0;
            this.lblInformacii.Text = "Информации за игрите";
            // 
            // btnGame1
            // 
            this.btnGame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.btnGame1.Location = new System.Drawing.Point(310, 101);
            this.btnGame1.Name = "btnGame1";
            this.btnGame1.Size = new System.Drawing.Size(202, 42);
            this.btnGame1.TabIndex = 2;
            this.btnGame1.Text = "ПРЕПОЗНАВАЊЕ НА ЖИВОТНИ";
            this.btnGame1.UseVisualStyleBackColor = false;
            this.btnGame1.Click += new System.EventHandler(this.btnGame1_Click);
            // 
            // btnGame2
            // 
            this.btnGame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.btnGame2.Location = new System.Drawing.Point(310, 192);
            this.btnGame2.Name = "btnGame2";
            this.btnGame2.Size = new System.Drawing.Size(202, 42);
            this.btnGame2.TabIndex = 4;
            this.btnGame2.Text = "ПОВРЗУВАЊЕ НА ЖИВОТНИТЕ";
            this.btnGame2.UseVisualStyleBackColor = false;
            this.btnGame2.Click += new System.EventHandler(this.btnGame2_Click);
            // 
            // btnGame3
            // 
            this.btnGame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.btnGame3.Location = new System.Drawing.Point(310, 280);
            this.btnGame3.Name = "btnGame3";
            this.btnGame3.Size = new System.Drawing.Size(202, 42);
            this.btnGame3.TabIndex = 5;
            this.btnGame3.Text = "MЕМОРИЈА ";
            this.btnGame3.UseVisualStyleBackColor = false;
            this.btnGame3.Click += new System.EventHandler(this.btnGame3_Click);
            // 
            // btnLearnAnimals
            // 
            this.btnLearnAnimals.Location = new System.Drawing.Point(625, 415);
            this.btnLearnAnimals.Name = "btnLearnAnimals";
            this.btnLearnAnimals.Size = new System.Drawing.Size(131, 23);
            this.btnLearnAnimals.TabIndex = 8;
            this.btnLearnAnimals.Text = "Научи ги животните\r\n";
            this.btnLearnAnimals.UseVisualStyleBackColor = true;
            this.btnLearnAnimals.Click += new System.EventHandler(this.btnLearnAnimals_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::NICK_Proekt.Properties.Resources.blob;
            this.pictureBox6.Location = new System.Drawing.Point(207, 43);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(355, 365);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // Informativna_stranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.btnLearnAnimals);
            this.Controls.Add(this.btnGame3);
            this.Controls.Add(this.btnGame2);
            this.Controls.Add(this.btnGame1);
            this.Controls.Add(this.lblInformacii);
            this.Controls.Add(this.pictureBox6);
            this.Name = "Informativna_stranica";
            this.Text = "Informativna_stranica";
            this.Load += new System.EventHandler(this.Informativna_stranica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacii;
        private System.Windows.Forms.Button btnGame1;
        private System.Windows.Forms.Button btnGame2;
        private System.Windows.Forms.Button btnGame3;
        private System.Windows.Forms.Button btnLearnAnimals;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}