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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            label1.Text = "        Игри за учење\n           за деца од \nаутистичниот спектар";
            label2.Text = "Во склоп  на оваа  апликација влегуваат  три игри  од\nразличен  карактер со  цел да  се научат дечињата од\nаутистичниот спектар, вештини кои би им помогнале во\nсекојдневниот живот.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Begin_Click(object sender, EventArgs e)
        {
            Informativna_stranica newForm = new Informativna_stranica();
            if (newForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }
    }
}
