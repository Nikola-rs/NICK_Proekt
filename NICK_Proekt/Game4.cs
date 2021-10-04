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
    public partial class Game4 : Form
    {
        private Point MouseLoc = Point.Empty;
        public List<PictureBox> DragImgs { get; set; } = new List<PictureBox>();
        public List<Label> Labels { get; set; } = new List<Label>();
        public Game4()
        {
            InitializeComponent();
            
            Labels.Add(cowLabel);
            Labels.Add(chickenLabel);
            Labels.Add(sheepLabel);
            Labels.Add(horseLabel);
            /*List<int> random = new List<int>(Enumerable.Range(1, 4));
            var rnd = new Random();
            var randomized = Labels.OrderBy(item => rnd.Next());
            foreach (var value in randomized)
            {
                if (label1.Name.Substring(label1.Name.Length - 1).Equals(value))
                {
                    label1.Name = "horseLabel";
                    label1.Text = "Коњ";
                }
            }*/
            
        }


        // Events
        private void dragImage_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLoc = e.Location;
        }
        private void dragImage_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox dragObj = (PictureBox)sender;
            if (MouseLoc == Point.Empty)
                return;

            if (e.Button != MouseButtons.Left)
                return;
            
            int count = 0;
            foreach (Label label in Labels)
            {
                int dx = Math.Abs(label.Location.X - dragObj.Location.X);
                int dy = Math.Abs(label.Location.Y - dragObj.Location.Y);
                Console.WriteLine(dx);
                Console.WriteLine(dy);
                Console.WriteLine(dragObj.Name.Substring(0, 3));
                if (dx <= 120 && dy <= 50 && label.Name.Substring(0, 3).Equals(dragObj.Name.Substring(0, 3)))
                {
                    label.BackColor = Color.Green;
                    //dragObj.Enabled = false;
                }
                else if (dx <= 120 && dy <= 50 && !label.Name.Substring(0, 3).Equals(dragObj.Name.Substring(0, 3)))
                    label.BackColor = Color.Red;
                //else label.BackColor = Color.Transparent;
            }
            foreach (Label l in Labels)
            {
                if (l.BackColor == Color.Green)
                {
                    count++;
                }
            }
            if (count == 4)
            {
                Timer MyTimer = new Timer();
                MyTimer.Interval = (50 * 60 * 1000); // 5 sec
                MyTimer.Tick += new EventHandler(MyTimer_Tick);
                MyTimer.Start();
                TocnoPogodenoZivotnoZaGame4 tocnoPogodenoZivotnoZaGame4 = new TocnoPogodenoZivotnoZaGame4();
                this.Hide();
                if (tocnoPogodenoZivotnoZaGame4.ShowDialog() == DialogResult.OK)
                {

                }
            }
            dragObj.Left = e.X + dragObj.Left - MouseLoc.X;
            dragObj.Top = e.Y + dragObj.Top - MouseLoc.Y;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("The form will now be closed.", "Time Elapsed");
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBackOnGames_Click(object sender, EventArgs e)
        {
            Informativna_stranica informativnaStranica = new Informativna_stranica();
            this.Hide();
            if (informativnaStranica.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void pbGame4Info_Click(object sender, EventArgs e)
        {
            SoundPlayer soundplayer = new SoundPlayer(NICK_Proekt.Properties.Resources.game4Intro);
            soundplayer.Play();
        }
    }
}
