using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NICK_Proekt
{
    public partial class Form1 : Form
    {
        //SoundPlayer player = new SoundPlayer(@"C:\Users\Daniela\Desktop\file_example_WAV_1MG.wav");
        SoundPlayer player = new SoundPlayer("file_example_WAV_1MG.wav");
        public Form1()
        {
            InitializeComponent();
        }

        



        private void Begin_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Begin_Click_1(object sender, EventArgs e)
        {
            player.Play();
            Informativna_stranica newForm = new Informativna_stranica();
            this.Hide();
            if (newForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void ucimeZaZivotni_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
