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
    public partial class TocnoPogodeniSiteZivotniMemorija : Form
    {
        public TocnoPogodeniSiteZivotniMemorija()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
        }

        private void btnIgrajPovtorno_Click(object sender, EventArgs e)
        {
            MemoryGame game = new MemoryGame();
            this.Hide();
            if (game.ShowDialog() == DialogResult.OK)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
