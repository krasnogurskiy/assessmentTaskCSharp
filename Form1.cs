using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        bool wheelIsMoved;
        //Timer gameTimer;
        Timer wheelTimer;
        Random rand;
        //int los;

        public Form1()
        {
            rand = new Random();
            InitializeComponent();
            wheelIsMoved = false;
            wheelTimer = new Timer();
            wheelTimer.Interval = 10;
            wheelTimer.Tick += WheelTimer_Tick;
        }


        //private Bitmap rotateImage()
        //{
        //    Bitmap rotatedImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        //    using (Graphics g = Graphics.FromImage(rotatedImage))
        //    {
        //        g.TranslateTransform((pictureBox1.Width / 2), pictureBox1.Height / 2); //set the rotation point as the center into the matrix
        //        g.RotateTransform(koloFortuny.kat); //rotate
        //        g.TranslateTransform(-pictureBox1.Width / 2, -pictureBox1.Height / 2); //restore rotation point into the matrix
        //        g.DrawImage(koloFortuny.tempObrazek, new Point(0, 0)); //draw the image on the new bitmap
        //    }
        //    return rotatedImage;
        //}

        private void RotateImage(PictureBox pb, Image img, float angle)
        {
            if (img == null || pb.Image == null)
                return;

            Image oldImage = pb.Image;
            pb.Image = GameWheel.RotateImage(img, angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }

        private void WheelTimer_Tick(object sender, EventArgs e)
        {

            if (wheelIsMoved && GameWheel.WheelTime > 0)
            {
                GameWheel.circule.kat += GameWheel.WheelTime / 10;
                GameWheel.circule.kat = GameWheel.circule.kat % 360;
                RotateImage(pictureBox1, GameWheel.circule.obrazek, GameWheel.circule.kat);
                GameWheel.WheelTime--;
            }
            GameWheel.circule.stan = Convert.ToInt32(Math.Ceiling(GameWheel.circule.kat / 18));
            if (GameWheel.circule.stan == 0)
            {
                GameWheel.circule.stan = 0;
            }
            else
            {
                GameWheel.circule.stan -= 1;
            }
            GameWheel.Points = GameWheel.circule.wartosciStanu[GameWheel.circule.stan];
            labelScoreInt.Text = GameWheel.Points.ToString();
            if (GameWheel.WheelTime == 0)
            {
                wheelIsMoved = false;
                wheelTimer.Stop();
            }
        }












        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            wheelIsMoved = true;
            Random rand = new Random();
            GameWheel.WheelTime = rand.Next(150, 200);
            wheelTimer.Start();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
