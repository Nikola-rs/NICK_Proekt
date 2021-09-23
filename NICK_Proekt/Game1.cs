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
    public partial class Game1 : Form
    {
        public Game1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void picDog_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Браво! Ова е кучето. Пробај друга игра!");
            TocnoPogodenoZivotno tocnoPogodenoZivotno = new TocnoPogodenoZivotno();
            if (tocnoPogodenoZivotno.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void picCat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ова не е кучето. Ова е маче. Обиди се повторно!");

        }

        private void picParrot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ова не е кучето. Ова е папагал. Обиди се повторно!");
        }
    }
}
