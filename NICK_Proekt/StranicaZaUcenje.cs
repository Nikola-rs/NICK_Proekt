using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            dog.URL = "dogPronunciation.wav";
            dog.controls.play();
        }

        private void pictureBoxParrotAudio_Click(object sender, EventArgs e)
        {
            parrot.URL = "parrotPronunciation.wav";
            parrot.controls.play();
        }

        private void pictureBoxChickenAudio_Click(object sender, EventArgs e)
        {
            chicken.URL = "chickenPronunciation.wav";
            chicken.controls.play();
        }

        private void pictureBoxCowAudio_Click(object sender, EventArgs e)
        {
            cow.URL = "cowPronunciation.wav";
            cow.controls.play();
        }

        private void pictureBoxSheepAudio_Click(object sender, EventArgs e)
        {
            sheep.URL = "sheepPronunciation.wav";
            sheep.controls.play();
        }

        private void pictureBoxPigAudio_Click(object sender, EventArgs e)
        {
            pig.URL = "pigPronunciation.wav";
            pig.controls.play();
        }

        private void pictureBoxGoatAudio_Click(object sender, EventArgs e)
        {
            goat.URL = "goatPronunciation.wav";
            goat.controls.play();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            cat.URL = "catPronunciation.wav";
            cat.controls.play();
        }

        private void pictureBoxMouse_Click(object sender, EventArgs e)
        {
            mouse.URL = "mousePronunciation.wav";
            mouse.controls.play();
        }

        private void pictureBoxHorse_Click_1(object sender, EventArgs e)
        {
            horse.URL = "horsePronunciation.wav";
            horse.controls.play();
        }
    }
}
