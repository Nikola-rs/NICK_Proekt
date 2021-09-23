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
    public partial class TocnoPogodeniSiteZivotniZaGame2 : Form
    {
        public TocnoPogodeniSiteZivotniZaGame2()
        {
            InitializeComponent();
        }

        private void btnIgrajPovtorno_Click(object sender, EventArgs e)
        {
            Game2 game2 = new Game2();
            this.Hide();
            if (game2.ShowDialog() == DialogResult.OK)
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
    }
}
