using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace app
{
    public class Kolo
    {
        public Bitmap obrazek;
        public Bitmap tempObrazek;
        public float kat;
        public int[] wartosciStanu;
        public int stan;

        public Kolo()
        {
            tempObrazek = new Bitmap(Properties.Resources.kolo);
            obrazek = new Bitmap(Properties.Resources.kolo);
            wartosciStanu = new int[] { 425, 225, 375, -1, 25, 275, 400, 325, 100, 0, 200, 50, 350, 3000, 175, 475, 300, 125, 75, 500 };
            kat = 0.0f;
        }

    }
    public class Player
    {
        private string name;
        private int score;
        private bool is_real_player;

        public Player(bool real_player, string _name)
        {
            is_real_player = real_player;
            name = _name;
        }
        public bool RealPlayer
        {
            get { return is_real_player; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Score
        {
            get { return score; }
        }
        public void ChangeScore(int points)
        {
            if (points >= 0)
            {
                score += points;
            }
            else if (points < 0 && (score - points) >= 0)
            {
                score -= points;
            }
        }
    }


    // Клас питання
    public static class Questions
    {
        private static Dictionary<string, string> questions = new Dictionary<string, string>();
        private static string question;
        private static string answer;

        public static string Question
        {
            get { return question; }
        }
        public static string Answer
        {
            get { return answer; }
        }
        public static void LoadQuestions(string path)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    string question = parts[0];
                    string answer = parts[1];
                    questions.Add(question, answer);
                }
            }
        }
        public static void ChooseQuestion()
        {
            Random random = new Random();
            int index = random.Next(questions.Count);
            KeyValuePair<string, string> randomQuestion = questions.ElementAt(index);
            question = randomQuestion.Key;
            answer = randomQuestion.Value;
        }
    }

    public static class GameWheel
    {
        public static Kolo circule = new Kolo();
        private static float wheel_times;
        private static int points;

        public static float WheelTime
        {
            get { return wheel_times; }
            set { wheel_times = value; }
        }
        public static int Points
        {
            get { return points; }
            set { points = value; }
        }
        public static Bitmap RotateImage(Image image, float angle)
        {
            return RotateImage(image, new PointF((float)image.Width / 2, (float)image.Height / 2), angle);
        }
        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Graphics g = Graphics.FromImage(rotatedBmp);
            g.TranslateTransform(offset.X, offset.Y);
            g.RotateTransform(angle);
            g.TranslateTransform(-offset.X, -offset.Y);
            g.DrawImage(image, new PointF(0, 0));
            return rotatedBmp;
        }
    }


    public class Round
    {

    }
    public class Game
    {
        private uint player_index;
        private int current_round;

        public List<Player> Players { get; set; }

        public Game()
        {
            Players = new List<Player>();
        }

        public void AddPlayer(string name, bool is_computer)
        {
            Players.Add(new Player(is_computer, name));
        }
    }
}
