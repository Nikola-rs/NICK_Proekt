﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace NICK_Proekt
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer ana = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        



        private void Begin_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Begin_Click_1(object sender, EventArgs e)
        {
            Informativna_stranica newForm = new Informativna_stranica();
            this.Hide();
            if (newForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void ucimeZaZivotni_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void virtualAna_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.virtualPlayerAna);
            soundplayer.Play();
        }
    }
}
