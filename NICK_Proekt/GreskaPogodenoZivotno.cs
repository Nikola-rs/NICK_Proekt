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
    public partial class GreskaPogodenoZivotno : Form
    {
        WindowsMediaPlayer game1Failed = new WindowsMediaPlayer();
        public GreskaPogodenoZivotno()
        {
            InitializeComponent();

            pictureBox1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;


        }

        private void GreskaPogodenoZivotno_Load(object sender, EventArgs e)
        {

        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            //DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Game1 game1 = new Game1();
            this.Hide();
            if (game1.ShowDialog() == DialogResult.OK)
            {
            
            }
        }

        private void btnBackToGames_Click(object sender, EventArgs e)
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

        private void pbGame1Failed_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.game1Failed);
            soundplayer.Play();
        }
    }
}
