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
            this.lblGame1 = new System.Windows.Forms.Label();
            this.btnGame2 = new System.Windows.Forms.Button();
            this.btnGame3 = new System.Windows.Forms.Button();
            this.lblGame2 = new System.Windows.Forms.Label();
            this.lblGame3 = new System.Windows.Forms.Label();
            this.btnLearnAnimals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformacii
            // 
            this.lblInformacii.AutoSize = true;
            this.lblInformacii.Location = new System.Drawing.Point(334, 9);
            this.lblInformacii.Name = "lblInformacii";
            this.lblInformacii.Size = new System.Drawing.Size(125, 13);
            this.lblInformacii.TabIndex = 0;
            this.lblInformacii.Text = "Информации за игрите";
            // 
            // btnGame1
            // 
            this.btnGame1.Location = new System.Drawing.Point(46, 62);
            this.btnGame1.Name = "btnGame1";
            this.btnGame1.Size = new System.Drawing.Size(202, 42);
            this.btnGame1.TabIndex = 2;
            this.btnGame1.Text = "ПРЕПОЗНАВАЊЕ НА ЖИВОТНИ";
            this.btnGame1.UseVisualStyleBackColor = true;
            this.btnGame1.Click += new System.EventHandler(this.btnGame1_Click);
            // 
            // lblGame1
            // 
            this.lblGame1.AutoSize = true;
            this.lblGame1.BackColor = System.Drawing.Color.White;
            this.lblGame1.Location = new System.Drawing.Point(21, 107);
            this.lblGame1.Name = "lblGame1";
            this.lblGame1.Size = new System.Drawing.Size(57, 13);
            this.lblGame1.TabIndex = 3;
            this.lblGame1.Text = "lbl za igra1";
            // 
            // btnGame2
            // 
            this.btnGame2.Location = new System.Drawing.Point(283, 245);
            this.btnGame2.Name = "btnGame2";
            this.btnGame2.Size = new System.Drawing.Size(202, 42);
            this.btnGame2.TabIndex = 4;
            this.btnGame2.Text = "ПОВРЗУВАЊЕ НА ЖИВОТНИТЕ";
            this.btnGame2.UseVisualStyleBackColor = true;
            this.btnGame2.Click += new System.EventHandler(this.btnGame2_Click);
            // 
            // btnGame3
            // 
            this.btnGame3.Location = new System.Drawing.Point(532, 62);
            this.btnGame3.Name = "btnGame3";
            this.btnGame3.Size = new System.Drawing.Size(202, 42);
            this.btnGame3.TabIndex = 5;
            this.btnGame3.Text = "MЕМОРИЈА ";
            this.btnGame3.UseVisualStyleBackColor = true;
            this.btnGame3.Click += new System.EventHandler(this.btnGame3_Click);
            // 
            // lblGame2
            // 
            this.lblGame2.AutoSize = true;
            this.lblGame2.BackColor = System.Drawing.Color.White;
            this.lblGame2.Location = new System.Drawing.Point(224, 292);
            this.lblGame2.MaximumSize = new System.Drawing.Size(320, 0);
            this.lblGame2.Name = "lblGame2";
            this.lblGame2.Size = new System.Drawing.Size(57, 13);
            this.lblGame2.TabIndex = 6;
            this.lblGame2.Text = "lbl za igra1";
            // 
            // lblGame3
            // 
            this.lblGame3.AutoSize = true;
            this.lblGame3.BackColor = System.Drawing.Color.White;
            this.lblGame3.Location = new System.Drawing.Point(492, 107);
            this.lblGame3.Name = "lblGame3";
            this.lblGame3.Size = new System.Drawing.Size(57, 13);
            this.lblGame3.TabIndex = 7;
            this.lblGame3.Text = "lbl za igra1";
            // 
            // btnLearnAnimals
            // 
            this.btnLearnAnimals.Location = new System.Drawing.Point(603, 351);
            this.btnLearnAnimals.Name = "btnLearnAnimals";
            this.btnLearnAnimals.Size = new System.Drawing.Size(131, 23);
            this.btnLearnAnimals.TabIndex = 8;
            this.btnLearnAnimals.Text = "Научи ги животните\r\n";
            this.btnLearnAnimals.UseVisualStyleBackColor = true;
            this.btnLearnAnimals.Click += new System.EventHandler(this.btnLearnAnimals_Click);
            // 
            // Informativna_stranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.btnLearnAnimals);
            this.Controls.Add(this.lblGame3);
            this.Controls.Add(this.lblGame2);
            this.Controls.Add(this.btnGame3);
            this.Controls.Add(this.btnGame2);
            this.Controls.Add(this.lblGame1);
            this.Controls.Add(this.btnGame1);
            this.Controls.Add(this.lblInformacii);
            this.Name = "Informativna_stranica";
            this.Text = "Informativna_stranica";
            this.Load += new System.EventHandler(this.Informativna_stranica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacii;
        private System.Windows.Forms.Button btnGame1;
        private System.Windows.Forms.Label lblGame1;
        private System.Windows.Forms.Button btnGame2;
        private System.Windows.Forms.Button btnGame3;
        private System.Windows.Forms.Label lblGame2;
        private System.Windows.Forms.Label lblGame3;
        private System.Windows.Forms.Button btnLearnAnimals;
    }
}