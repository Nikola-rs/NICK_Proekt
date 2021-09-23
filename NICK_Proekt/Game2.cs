using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NICK_Proekt
{
    public partial class Game2 : Form
    {
        public Game2()
        {
            InitializeComponent();
            //lbForMouse.BackColor = Color.Transparent;
            
        }

        private void lblMouse_Click(object sender, EventArgs e)
        {

        }

        private void lbforDog_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDog.Visible = true;
            if (lbforDog.SelectedIndex!=0)
            {
                lbforDog.SelectedIndex = -1;
                lblDog.Text = "Избра грешка име на животно, пробај повторно!";
            }
            else
            {
                lbforDog.Enabled = false;
                lblDog.Text = "Браво! Го избра точното име на животното.";
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
                lblCat.Text = "Браво! Го избра точното име на животното.";
            }
            else
            {
                lbForCat.SelectedIndex = -1;
                lblCat.Text = "Избра грешка име на животно, пробај повторно!";
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
                lblParrot.Text = "Браво! Го избра точното име на животното.";
            }
            else
            {
                lbForParrot.SelectedIndex = -1;
                lblParrot.Text = "Избра грешка име на животно, пробај повторно!";
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
                lblMouse.Text = "Браво! Го избра точното име на животното.";   
            }
            else
            {
                lbForMouse.SelectedIndex = -1;
                lblMouse.Text = "Избра грешка име на животно, пробај повторно!";
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
    }
}
