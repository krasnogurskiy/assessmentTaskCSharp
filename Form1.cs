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
        Kolo koloFortuny;
        bool wheelIsMoved;
        float startWheelTimes;
        float wheelTimes;
        //Timer gameTimer;
        Timer wheelTimer;
        Random rand;
        //int los;

        public Form1()
        {
            rand = new Random();
            //los = rand.Next(0, hasla.Length);
            koloFortuny = new Kolo();
            InitializeComponent();
            wheelIsMoved = false;
            wheelTimer = new Timer();
            wheelTimer.Interval = 10;
            wheelTimer.Tick += WheelTimer_Tick;
            wheelTimes = 100;
        }


        public Bitmap rotateImage()
        {
            Bitmap rotatedImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform((pictureBox1.Width / 2), pictureBox1.Height / 2); //set the rotation point as the center into the matrix
                g.RotateTransform(koloFortuny.kat); //rotate
                g.TranslateTransform(-pictureBox1.Width / 2, -pictureBox1.Height / 2); //restore rotation point into the matrix
                g.DrawImage(koloFortuny.tempObrazek, new Point(0, 0)); //draw the image on the new bitmap
            }
            return rotatedImage;
        }

        public static Bitmap RotateImage(Image image, float angle)
        {
            return RotateImage(image, new PointF((float)image.Width / 2, (float)image.Height / 2), angle);
        }

        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            //create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            g.TranslateTransform(offset.X, offset.Y);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-offset.X, -offset.Y);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }

        private void RotateImage(PictureBox pb, Image img, float angle)
        {
            if (img == null || pb.Image == null)
                return;

            Image oldImage = pb.Image;
            pb.Image = RotateImage(img, angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }

        private void WheelTimer_Tick(object sender, EventArgs e)
        {
            //label4.Visible = false;

            if (wheelIsMoved && wheelTimes > 0)
            {
                koloFortuny.kat += wheelTimes / 10;
                koloFortuny.kat = koloFortuny.kat % 360;
                RotateImage(pictureBox1, koloFortuny.obrazek, koloFortuny.kat);
                wheelTimes--;
            }

            koloFortuny.stan = Convert.ToInt32(Math.Ceiling(koloFortuny.kat / 18));

            if (koloFortuny.stan == 0)
            {
                koloFortuny.stan = 0;
            }
            else
            {
                koloFortuny.stan -= 1;
            }

            //label1.Text = Convert.ToString(koloFortuny.kat);
            //label2.Text = Convert.ToString(koloFortuny.stan);
            labelScoreInt.Text = Convert.ToString(koloFortuny.wartosciStanu[koloFortuny.stan]);

            //gra.stawka = koloFortuny.wartosciStanu[koloFortuny.stan];
            //gra.podpowiedz[2] = "Grasz o " + gra.stawka;

            if (wheelTimes == 0)
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
            wheelTimes = rand.Next(150, 200);
            startWheelTimes = wheelTimes;

                
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
