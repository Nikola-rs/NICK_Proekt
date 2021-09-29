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
    public partial class Game1 : Form
    {
        public WindowsMediaPlayer gameInfo = new WindowsMediaPlayer();

        public RandomNumber randomNumber = new RandomNumber();

        public int random_number = 1;
        public Game1()
        {
            InitializeComponent();


            random_number = randomNumber.random_number;
            if (random_number == 1)
            {
                lblNaslov.Text = "МОЖЕШ ЛИ\n ДА ГО ПРЕПОЗНАЕШ\n КУЧЕТО?";
            }
            else if(random_number == 2)
            {
                lblNaslov.Text = "МОЖЕШ ЛИ\n ДА ГО ПРЕПОЗНАЕШ\n МАЧЕТО?";
            }
            else
            {
                lblNaslov.Text = "МОЖЕШ ЛИ\n ДА ГО ПРЕПОЗНАЕШ\n ПАПАГАЛОТ?";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void picDog_Click(object sender, EventArgs e)
        {
            if(random_number == 1)
            {
                randomNumber.random_number = random_number;
                TocnoPogodenoZivotno tocnoPogodenoZivotno = new TocnoPogodenoZivotno();
                this.Hide();
                if (tocnoPogodenoZivotno.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
            else
            {
                randomNumber.random_number = random_number;
                GreskaPogodenoZivotno greskaPogodenoZivotno = new GreskaPogodenoZivotno();
                this.Hide();
                if (greskaPogodenoZivotno.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void picCat_Click(object sender, EventArgs e)
        {
            if (random_number == 2)
            {
                randomNumber.random_number = random_number;
                TocnoPogodenoZivotno tocnoPogodenoZivotno = new TocnoPogodenoZivotno();
                this.Hide();
                if (tocnoPogodenoZivotno.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
            else
            {
                randomNumber.random_number = random_number;
                GreskaPogodenoZivotno greskaPogodenoZivotno = new GreskaPogodenoZivotno();
                this.Hide();
                if (greskaPogodenoZivotno.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void picParrot_Click(object sender, EventArgs e)
        {

            if (random_number == 3)
            {
                randomNumber.random_number = random_number;
                TocnoPogodenoZivotno tocnoPogodenoZivotno = new TocnoPogodenoZivotno();
                this.Hide();
                if (tocnoPogodenoZivotno.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
            else
            {
                randomNumber.random_number = random_number;
                GreskaPogodenoZivotno greskaPogodenoZivotno = new GreskaPogodenoZivotno();
                this.Hide();
                if (greskaPogodenoZivotno.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void btnBackOnGames_Click(object sender, EventArgs e)
        {
            Informativna_stranica informativnaStranica = new Informativna_stranica();
            this.Hide();
            if (informativnaStranica.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void Game1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pbGame1Info_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.game1);
            soundplayer.Play();
        }
    }
}
