using System;
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
    public partial class StranicaZaUcenje : Form
    {
        WindowsMediaPlayer cat = new WindowsMediaPlayer();
        WindowsMediaPlayer dog = new WindowsMediaPlayer();
        WindowsMediaPlayer horse = new WindowsMediaPlayer();
        WindowsMediaPlayer mouse = new WindowsMediaPlayer();
        WindowsMediaPlayer parrot = new WindowsMediaPlayer();
        WindowsMediaPlayer cow = new WindowsMediaPlayer();
        WindowsMediaPlayer sheep = new WindowsMediaPlayer();
        WindowsMediaPlayer goat = new WindowsMediaPlayer();
        WindowsMediaPlayer chicken = new WindowsMediaPlayer();
        WindowsMediaPlayer pig = new WindowsMediaPlayer();

        public StranicaZaUcenje()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StranicaZaUcenje_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Informativna_stranica informativnaStranica = new Informativna_stranica();
            this.Hide();
            if (informativnaStranica.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
            
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBoxDogAudio_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.dogPronunciation);
            soundplayer.Play();
        }

        private void pictureBoxParrotAudio_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.parrotPronunciation);
            soundplayer.Play();
        }

        private void pictureBoxChickenAudio_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.chickenPronunciation);
            soundplayer.Play();
        }

        private void pictureBoxCowAudio_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.cowPronunciation);
            soundplayer.Play();
        }

        private void pictureBoxSheepAudio_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.sheepPronunciation);
            soundplayer.Play();
        }

        private void pictureBoxPigAudio_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.pigPronunciation);
            soundplayer.Play();
        }

        private void pictureBoxGoatAudio_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.goatPronunciation);
            soundplayer.Play();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.catPronunciation);
            soundplayer.Play();
        }

        private void pictureBoxMouse_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.mousePronunciation);
            soundplayer.Play();
        }

        private void pictureBoxHorse_Click_1(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.horsePronunciation);
            soundplayer.Play();
        }
    }
}
