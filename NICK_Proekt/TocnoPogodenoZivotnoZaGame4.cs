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

namespace NICK_Proekt
{
    public partial class TocnoPogodenoZivotnoZaGame4 : Form
    {
        public TocnoPogodenoZivotnoZaGame4()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnIgrajPovtorno_Click(object sender, EventArgs e)
        {
            Game1 game1 = new Game1();
            this.Hide();
            if (game1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnNazadIzborIgra_Click(object sender, EventArgs e)
        {
            Informativna_stranica informativna_Stranica = new Informativna_stranica();
            this.Hide();
            if (informativna_Stranica.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pbGame1Correct_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.game4Congrats);
            soundplayer.Play();
        }
    }
}
