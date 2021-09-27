using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NICK_Proekt
{
    public partial class StranicaZaUcenje : Form
    {
        SoundPlayer playerCat = new SoundPlayer(@"C:\Users\Daniela\Downloads\catPronunciation.wav");
        SoundPlayer playerDog = new SoundPlayer(@"C:\Users\Daniela\Downloads\dogPronunciation.wav");
        SoundPlayer playerHorse = new SoundPlayer(@"C:\Users\Daniela\Downloads\horsePronunciation.wav");
        SoundPlayer playerMouse = new SoundPlayer(@"C:\Users\Daniela\Downloads\mousePronunciation.wav");
        SoundPlayer playerGoat = new SoundPlayer(@"C:\Users\Daniela\Downloads\goatPronunciation.wav");
        SoundPlayer playerCow = new SoundPlayer(@"C:\Users\Daniela\Downloads\cowPronunciation.wav");
        SoundPlayer playerParrot = new SoundPlayer(@"C:\Users\Daniela\Downloads\parrotPronunciation.wav");
        SoundPlayer playerSheep = new SoundPlayer(@"C:\Users\Daniela\Downloads\sheepPronunciation.wav");
        SoundPlayer playerChicken = new SoundPlayer(@"C:\Users\Daniela\Downloads\chickenPronunciation.wav");
        SoundPlayer playerPig = new SoundPlayer(@"C:\Users\Daniela\Downloads\pigPronunciation.wav");

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
            //DialogResult = System.Windows.Forms.DialogResult.Cancel;
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

        private void pictureBoxCatAudio_Click(object sender, EventArgs e)
        {
            playerCat.Play();
        }

        private void pictureBoxMouseAudio_Click(object sender, EventArgs e)
        {
            playerMouse.Play();
        }

        private void pictureBoxDogAudio_Click(object sender, EventArgs e)
        {
            playerDog.Play();
        }

        private void pictureBoxParrotAudio_Click(object sender, EventArgs e)
        {
            playerParrot.Play();
        }

        private void pictureBoxChickenAudio_Click(object sender, EventArgs e)
        {
            playerChicken.Play();
        }

        private void pictureBoxCowAudio_Click(object sender, EventArgs e)
        {
            playerCow.Play();
        }

        private void pictureBoxSheepAudio_Click(object sender, EventArgs e)
        {
            playerSheep.Play();
        }

        private void pictureBoxPigAudio_Click(object sender, EventArgs e)
        {
            playerPig.Play();
        }

        private void pictureBoxGoatAudio_Click(object sender, EventArgs e)
        {
            playerGoat.Play();
        }

        private void pictureBoxHorseAudio_Click(object sender, EventArgs e)
        {
            playerHorse.Play();
        }
    }
}
