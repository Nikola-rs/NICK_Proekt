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
    public partial class TocnoPogodenoZivotno : Form
    {
        public TocnoPogodenoZivotno()
        {
            InitializeComponent();
            
            /* Ako nekoj znae neka go implimintire
            Game1 game1 = new Game1();
            int randon_number = game1.random_number;
            if(randon_number == 1)
            {
                lblTocno.Text = "Да тое е кучето";
            }*/
           
        }

        private void btnNazadIzborIgra_Click(object sender, EventArgs e)
        {
            Informativna_stranica informativna_Stranica = new Informativna_stranica();
            this.Hide();
            if(informativna_Stranica.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnIgrajPovtorno_Click(object sender, EventArgs e)
        {
            Game1 game1 = new Game1();
            this.Hide();
            if (game1.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
