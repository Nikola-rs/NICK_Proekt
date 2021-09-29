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
    
    public partial class Game2 : Form
    {
        WindowsMediaPlayer game2Info = new WindowsMediaPlayer();
        WindowsMediaPlayer game2OneCorrect = new WindowsMediaPlayer();
        WindowsMediaPlayer game2OneFailed = new WindowsMediaPlayer();

        Boolean dogFlag = false;
        Boolean catFlag = false;
        Boolean mouseFlag = false;
        Boolean parrotFlag = false;
        public Game2()
        {
            InitializeComponent();
            // this doesnt work lbForMouse.BackColor = Color.Transparent;
            // making all transparent for better looking
            pbCat.BackColor = Color.Transparent;
            pbDog.BackColor = Color.Transparent;
            pbParrot.BackColor = Color.Transparent;
            pbMouse.BackColor = Color.Transparent;
            lblCat.BackColor = Color.Transparent;
            lblDog.BackColor = Color.Transparent;
            lblParrot.BackColor = Color.Transparent;
            lblMouse.BackColor = Color.Transparent;
        }

        private void lblMouse_Click(object sender, EventArgs e)
        {

        }

        private void lbforDog_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDog.Visible = true;
            if (lbforDog.SelectedIndex != 0)
            {
                lbforDog.SelectedIndex = -1;
                lblDog.Text = "Грешка! Пробај повторно";
                SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.game2OneFailed);
                soundplayer.Play();
            }
            else
            {
                lbforDog.Enabled = false;
                lblDog.Text = "Го избра точното име";
                dogFlag = true;
                if (parrotFlag == false || catFlag == false || mouseFlag == false || dogFlag == false)
                {
                    SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.game2OneCorrect);
                    soundplayer.Play();
                }
            }


            if (lbForMouse.Enabled == false && lbForCat.Enabled == false && lbforDog.Enabled == false && lbForParrot.Enabled == false)
            {
                TocnoPogodeniSiteZivotniZaGame2 newForm = new TocnoPogodeniSiteZivotniZaGame2();
                this.Hide();
                if (newForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void lbForCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCat.Visible = true;
            if (lbForCat.SelectedItem != null && lbForCat.SelectedItem.ToString().Equals("Маче"))
            { 
                lbForCat.Enabled = false;
                lblCat.Text = "Го избра точното име";
                catFlag = true;
                if (parrotFlag == false || catFlag == false || mouseFlag == false || dogFlag == false)
                {
                    SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.game2OneCorrect);
                    soundplayer.Play();
                }
            }
            else
            {
                lbForCat.SelectedIndex = -1;
                lblCat.Text = "Грешка! Пробај повторно";
                SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.game2OneFailed);
                soundplayer.Play();
            }


            if (lbForMouse.Enabled == false && lbForCat.Enabled == false && lbforDog.Enabled == false && lbForParrot.Enabled == false)
            {
                TocnoPogodeniSiteZivotniZaGame2 newForm = new TocnoPogodeniSiteZivotniZaGame2();
                this.Hide();
                if (newForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void lbForParrot_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblParrot.Visible = true;
            if (lbForParrot.SelectedItem != null && lbForParrot.SelectedItem.ToString().Equals("Папагал"))
            {
                lbForParrot.Enabled = false;
                lblParrot.Text = "Го избра точното име";
                parrotFlag = true;
                if (parrotFlag == false || catFlag == false || mouseFlag == false || dogFlag == false)
                {
                    SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.game2OneCorrect);
                    soundplayer.Play();
                }
            }
            else
            {
                lbForParrot.SelectedIndex = -1;
                lblParrot.Text = "Грешка! Пробај повторно";
                SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.game2OneFailed);
                soundplayer.Play();
            }


            if (lbForMouse.Enabled == false && lbForCat.Enabled == false && lbforDog.Enabled == false && lbForParrot.Enabled == false)
            {
                TocnoPogodeniSiteZivotniZaGame2 newForm = new TocnoPogodeniSiteZivotniZaGame2();
                this.Hide();
                if (newForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void lbForMouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMouse.Visible = true;
            if (lbForMouse.SelectedItem != null && lbForMouse.SelectedItem.ToString().Equals("Глувче"))
            {
                lbForMouse.Enabled = false;
                lblMouse.Text = "Го избра точното име";
                mouseFlag = true;
                if (parrotFlag == false || catFlag == false || mouseFlag == false || dogFlag == false)
                {
                    SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.game2OneCorrect);
                    soundplayer.Play();
                }
            }
            else
            {
                lbForMouse.SelectedIndex = -1;
                lblMouse.Text = "Грешка! Пробај повторно";
                SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.game2OneFailed);
                soundplayer.Play();
            }


            if (lbForMouse.Enabled == false && lbForCat.Enabled == false && lbforDog.Enabled == false && lbForParrot.Enabled == false)
            {
                TocnoPogodeniSiteZivotniZaGame2 newForm = new TocnoPogodeniSiteZivotniZaGame2();
                this.Hide();
                if (newForm.ShowDialog() == DialogResult.OK)
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

        private void Game2_Load(object sender, EventArgs e)
        {

        }

        private void lblNaslov_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pbGame2Info_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.game2);
            soundplayer.Play();
        }
    }
}
