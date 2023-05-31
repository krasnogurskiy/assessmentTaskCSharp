using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime;

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
    public class Player : IComparable
    {
        private string name;
        private int score;
        private bool is_real_player;
        private bool is_playing_now;

        public Player(bool real_player, string _name)
        {
            is_real_player = real_player;
            name = _name;
            is_playing_now = false;
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
        public bool PlayingNow
        {
            get { return is_real_player; }
            set { is_playing_now = value; }
        }
        public void ChangeScore(int points)
        {
            if (points >= 0)
            {
                score += points;
            }
            else if (points < 0 && (score + points) >= 0)
            {
                score += points;
            }
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Player))
            {
                throw new ArgumentException("Порівнюваний об'єкт не є гравцем.");
            }
            Player player = obj as Player;
            return Score.CompareTo(player.Score);
        }

        public void ResetScore()
        {
            score = 0;
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
                    questions.Add(parts[0], parts[1]);
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
            questions.Remove(question);
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
    public class Game
    {
        private int player_index;
        private int current_round;
        private List<string> answer_array;
        private string level;
        private string file_path;
        private int current_score;
        private bool is_end_game;
        private List<Player> Players;
        private int unknown_letters;
        private bool is_end_round;

        public int CurrentScore
        {
            get { return current_score; }
            set { current_score = value; }
        }
        public bool EndGame
        {
            get { return is_end_game; }
        }
        public bool EndRound
        {
            get { return is_end_round; }
            set { is_end_round = value; }
        }
        public int PlayerIndex
        {
            get { return player_index; }
        }
        public int CurrentRound
        {
            get { return current_round; }
        }
        public Player CurrentPlayer
        {
            get { return Players[player_index]; }
        }
        public List<string> AnswerArray
        {
            get { return answer_array; }
        }
        public Game(string _level, List<Player> players)
        {
            current_round = 0;
            is_end_game = false;
            Players = players;
            switch (_level)
            {
                case "Легкий":
                    file_path = @"../../Questions/eassy.txt";
                    break;
                case "Середній":
                    file_path = @"../../Questions/middle.txt";
                    break;
                case "Важкий":
                    file_path = @"../../Questions/difficult.txt";
                    break;
            }
            Questions.LoadQuestions(file_path);
        }

        public void AddPlayer(string name, bool is_computer)
        {
            Players.Add(new Player(is_computer, name));
        }
        public void NewRound()
        {
            Random rand = new Random();
            player_index = rand.Next(0, 3);
            CurrentPlayer.PlayingNow = true;
            is_end_round = false;
            current_round += 1;
            Questions.ChooseQuestion();
            answer_array = Questions.Answer.ToUpper().ToCharArray().Select(c => c.ToString()).ToList();
            unknown_letters = answer_array.Count();
            if (current_round == 3)
            {
                is_end_game = true;
            }
        }
        public void LetterClick(string letter)
        {
            bool guess = false;
            current_score = GameWheel.Points;
            int score = 0;
            foreach (string i in answer_array)
            {
                if (i == letter)
                {
                    score += current_score;
                    unknown_letters -= 1;
                    guess = true;
                }
            }
            if (unknown_letters == 0)
            {
                is_end_round = true;
            }
            if (guess)
            {
                Players[player_index].ChangeScore(score);
            }
            else
            {
                NextPlayer();
            }

        }
        public bool CheckAnswer(string line)
        {
            current_score = GameWheel.Points;
            if (line == Questions.Answer)
            {
                CurrentPlayer.ChangeScore(current_score * unknown_letters);
                is_end_round = true;
                return true;
            }
            else
            {
                NextPlayer();
                return false;
            }
        }
        public void NextPlayer()
        {
            CurrentPlayer.PlayingNow = false;
            if (player_index == 2)
            {
                player_index = 0;
            }
            else
            {
                player_index += 1;
            }
            CurrentPlayer.PlayingNow = true;
        }
        public Player Winner()
        {
            return Players.Max();
        }
    }
}
