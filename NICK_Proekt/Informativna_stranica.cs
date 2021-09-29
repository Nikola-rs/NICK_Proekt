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
    public partial class Informativna_stranica : Form
    {
        WindowsMediaPlayer greenButton = new WindowsMediaPlayer();
        WindowsMediaPlayer chooseGame = new WindowsMediaPlayer();
        public Informativna_stranica()
        {
            InitializeComponent();
        }

        private void Informativna_stranica_Load(object sender, EventArgs e)
        {
            
            
            /*
            //svojstva za lblGame1
            lblGame1.Text = "Целта на оваа игра е да го препознаето типот на\nживотното. Животните  се  дел  од  нашиот  живот,\nтие  нè  прават  среќни  и  всушност тие се наши\nдругари. За таа цел, овој дел од  играта овозмо-\nжува токму препозавање и понатамошно учење\nна животни. ";
            lblGame1.BackColor = Color.Transparent;
            btnGame1.Font = new Font(btnGame1.Font, FontStyle.Bold);

            //svojstva za lblGame2
            lblGame2.Text = "Целта на оваа игра е да ги препознаете животните со нивните имиња."
                          + " Поврзување на животните е важна вештина, особено за децата со послaба"
                          + " функционалност кои припаѓаат на аутистичниот спектар. Способноста"
                          + " за групирање на животните им помага на децата со аутизам да"
                          + " развијат поголемо разбирање на карактеристиките или атрибутите."
                          + " Способноста за групирање и категоризирање на предмети е често"
                          + " предуслов за вежбање активности за подготовка на работа во училиште.";
            lblGame2.BackColor = Color.Transparent;
            btnGame2.Font = new Font(btnGame2.Font, FontStyle.Bold);

            //svojstva za lblGame
            lblGame3.Text = "Целта на оваа игра е да се погодат истите сликички.\n"
                          + "Секојдневна вежба на меморијата е многу добар тре-\n"
                          + "нинг за одржување на оваа есенцијална способност\n"
                          + "или пак подобрување на меморијата доколку се\n"
                          + "увиди дека детенцето има проблем во оваа област.\n"
                          + "Наместо да биде детето принудено да памти работи\n"
                          + "кои  впрочем  се  небитни  за  него, сметаме дека \n"
                          + "преку забавна игра со помош на  разнобојните \n"
                          + "интересни сликички за животни, секое дете ќе \n"
                          + "има  можност да си ја вежба својата меморија.\n";
            lblGame3.BackColor = Color.Transparent;
            btnGame3.Font = new Font(btnGame3.Font, FontStyle.Bold);
            */
        }

        private void btnGame1_Click(object sender, EventArgs e)
        {
            Game1 newForm = new Game1();
            this.Hide();
            if (newForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void btnGame3_Click(object sender, EventArgs e)
        {
            MemoryGame memoryGame = new MemoryGame();
            this.Hide();
            if(memoryGame.ShowDialog() == DialogResult.OK) {

            }
         }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            Game2 game2 = new Game2();
            this.Hide();
            if (game2.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnLearnAnimals_Click(object sender, EventArgs e)
        {
            StranicaZaUcenje stranicaZaUcenje = new StranicaZaUcenje();
            this.Hide();
            if (stranicaZaUcenje.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void lblInformacii_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void greenButtonLearn_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.greenButtonLearning);
            soundplayer.Play();
        }

        private void pictureBoxChooseAGame_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.chooseAGame);
            soundplayer.Play();
        }
    }
}
