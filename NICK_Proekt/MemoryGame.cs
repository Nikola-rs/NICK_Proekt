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
    public partial class MemoryGame : Form
    {

        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "ö","ö","!","!","õ","õ","ô","ô",
            "ó","ó","ò","ò","ÿ","ÿ","˜","˜"


        };

        Label firstClicked, secondClicked;



        public MemoryGame()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void label_Click(object sender, EventArgs e)
        {

            if (firstClicked != null && secondClicked != null)
            {
                return;
            }

            Label clickedLabel = sender as Label;

            if (clickedLabel == null)
                return;

            if (clickedLabel.ForeColor == Color.Black)
                return;

            if(firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            CheckForWinner();

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
            {
                timer1.Start();
            }

        }


        private void CheckForWinner()
        {
            Label label;

            for(int i=0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }

            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;
            WaitSomeTime();
            TocnoPogodeniSiteZivotniMemorija newForm = new TocnoPogodeniSiteZivotniMemorija();
            this.Hide();
            if (newForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        public async void WaitSomeTime()
        {
            await Task.Delay(8000);
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pbGame2AllCorrect_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.game3Recording);
            soundplayer.Play();
        }

        private void btnBackOnGames_Click(object sender, EventArgs e)
        {
            Informativna_stranica informativnaStranica = new Informativna_stranica();
            this.Hide();
            if (informativnaStranica.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void AssignIconsToSquares()
        {
            Label label;
            int randomNumber;

            for(int i=0;i<tableLayoutPanel1.Controls.Count;i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
         
                }
                else
                    continue;

                randomNumber = random.Next(0, icons.Count);
                label.Text = icons[randomNumber];

                icons.RemoveAt(randomNumber);


            }
        }
    }
}
