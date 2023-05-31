using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{

    public partial class Form1 : Form
    {
        private bool wheelIsMoved;
        private System.Windows.Forms.Timer wheelTimer;
        private Random rand;
        private List<Letter> alphabet;
        private List<Letter> answer;
        private Game game;
        private List<Label> scores;


        public Form1(List<Player> players, string level)
        {
            rand = new Random();
            InitializeComponent();
            game = new Game(level, players);
            scores = new List<Label>() { player1_score, player2_score, player3_score };
            wheelIsMoved = false;
            wheelTimer = new System.Windows.Forms.Timer();
            wheelTimer.Interval = 10;
            wheelTimer.Tick += WheelTimer_Tick;
            alphabet = new List<Letter>();
            answer = new List<Letter>();
            alphabet_panel.Enabled = false;
            tool_panel.Enabled = false;
            player1_name.Text = players[0].Name;
            player2_name.Text = players[1].Name;
            player3_name.Text = players[2].Name;
            for (int i = 0; i < 3; ++i)
            {
                UpdateScore(players[i], i);
            }
            NewRound();
        }
        private void NewRound()
        {
            if (game.EndGame)
            {
                MessageBox.Show($"Гру завершено. За підсумками 3-ох раундів переміг" +
                    $" {game.Winner().Name} з рахунком {game.Winner().Score}", "Завершення гри", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                game.NewRound();
                round_lb.Text = "Раунд " + game.CurrentRound;
                labelScoreInt.Text = "0";
                alphabet_panel.Controls.Clear();
                CreateAlphabet();
                question.Text = "Питання: " + Questions.Question;
                answer_panel.Controls.Clear();
                CreateAnswer();
                status_lb.Text = game.CurrentPlayer.Name + " крутіть колесо";
                pictureBox1.Enabled = true;
                //if (!game.CurrentPlayer.RealPlayer)
                //{
                //    ComputerMode(game.CurrentPlayer);
                //}
            }
        }
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
            labelScoreInt.Text = GameWheel.circule.wartosciStanu[GameWheel.circule.stan].ToString();
            if (GameWheel.WheelTime == 0)
            {
                GameWheel.Points = int.Parse(labelScoreInt.Text);
                wheelIsMoved = false;
                wheelTimer.Stop();
                alphabet_panel.Enabled = true;
                tool_panel.Enabled = true;
                if (GameWheel.Points == 0)
                {
                    MessageBox.Show($"{game.CurrentPlayer.Name} ви банкрут.", "Банкрут", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    game.CurrentPlayer.ResetScore();
                    game.NextPlayer();
                    alphabet_panel.Enabled = false;
                    tool_panel.Enabled = false;
                    pictureBox1.Enabled = true;
                    status_lb.Text = game.CurrentPlayer.Name + " крутіть колесо";

                }
                else if (GameWheel.Points == -1)
                {
                    MessageBox.Show($"{game.CurrentPlayer.Name} ви пропускаєте хід.", "Пропуск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    game.NextPlayer();
                    alphabet_panel.Enabled = false;
                    tool_panel.Enabled = false;
                    pictureBox1.Enabled = true;
                    status_lb.Text = game.CurrentPlayer.Name + " крутіть колесо";
                }
                else
                {
                    status_lb.Text = game.CurrentPlayer.Name + " обирайте літеру";
                }
            }
        }
        private void CreateAlphabet()
        {
            List<string> letters = new List<string>() { "А", "Б", "В", "Г", "Ґ", "Д", "Е", "Є", "Ж", "З", "И",
            "І", "Ї", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ь",
            "Ю", "Я"};
            for (int i = 0; i < 33; ++i)
            {
                Letter letter = new Letter(letters[i], false);
                letter.Click += letter_Click;
                alphabet_panel.Controls.Add(letter);
                alphabet.Add(letter);
            }
        }

        private void CreateAnswer()
        {
            foreach (string i in game.AnswerArray)
            {
                Letter letter = new Letter(i, true);
                answer_panel.Controls.Add(letter);
                answer.Add(letter);
            }
        }
        private void FindLetter(Letter letter)
        {
            foreach (Letter i in answer)
            {
                if (letter == i)
                {
                    i.GuessedLetter();
                }
            }
        }

        private void letter_Click(object sender, EventArgs e)
        {
            Letter letter = sender as Letter;
            game.LetterClick(letter.Current_letter);
            FindLetter(letter);
            letter.BackColor = Color.Khaki;
            letter.Enabled = false;
            letter.Active = false;
            alphabet_panel.Enabled = false;
            tool_panel.Enabled = false;
            pictureBox1.Enabled = true;
            if (letter.Vowel)
            {
                alphabet = alphabet.Where(l => l.Vowel && l.Active).Select(l => { l.Enabled = false; return l; }).ToList();
            }
            UpdateScore(game.CurrentPlayer, game.PlayerIndex);
            if (game.EndRound == true)
            {
                MessageBox.Show("Раунд " + game.CurrentRound.ToString() + " завершено.", "Завершення раунду", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                NewRound();
            }
            else status_lb.Text = game.CurrentPlayer.Name + " крутіть колесо";
            //if(!game.CurrentPlayer.RealPlayer)
            //{
            //    ComputerMode(game.CurrentPlayer);
            //}
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            wheelIsMoved = true;
            Random rand = new Random();
            GameWheel.WheelTime = rand.Next(150, 200);
            wheelTimer.Start();
            pictureBox1.Enabled = false;
        }
        private void labelBuy_Click(object sender, EventArgs e)
        {

        }
        private void BuyVowel()
        {
            if (game.CurrentPlayer.Score >= 250)
            {
                game.CurrentPlayer.ChangeScore(-250);
                alphabet = alphabet.Where(l => l.Vowel && l.Active).Select(l => { l.Enabled = true; return l; }).ToList();
                UpdateScore(game.CurrentPlayer, game.PlayerIndex);
            }
            else
            {
                MessageBox.Show($"{game.CurrentPlayer.Name}, на жаль, у вас замало балів для цієї покупки.", "Купівля голосних літер",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            BuyVowel();
        }

        private void answerBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (game.CheckAnswer(answerBox.Text))
            {
                MessageBox.Show($"Правильна відповідь! Вітаємо. {game.CurrentRound} раунд завершено", "Повна відповідь", MessageBoxButtons.OK, MessageBoxIcon.Information);
                answerBox.Clear();
                NewRound();
            }
            else
            {
                MessageBox.Show($"На жаль, це неправильна відповідь {game.CurrentPlayer.Name}. Ваші бали обнулено", "Повна відповідь", MessageBoxButtons.OK, MessageBoxIcon.Information);
                game.CurrentPlayer.ResetScore();
                status_lb.Text = game.CurrentPlayer.Name + " крутіть колесо";
            }
            alphabet_panel.Enabled = false;
            tool_panel.Enabled = false;
            //if (!game.CurrentPlayer.RealPlayer)
            //{
            //    ComputerMode(game.CurrentPlayer);
            //}
        }

        private void answer_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        //private void ComputerMode(Player player)
        //{
        //    Thread.Sleep(1000);
        //    status_lb.Text = game.CurrentPlayer.Name + " крутіть колесо";
        //    pictureBox1_Click(pictureBox1, EventArgs.Empty);
        //    status_lb.Text = game.CurrentPlayer.Name + " обирайте літеру";
        //    Thread.Sleep(1000);
        //    if(player.Score >= 250)
        //    {
        //        int choise = rand.Next(0, 1);
        //        if(choise == 1)
        //        {
        //            BuyVowel();
        //        }
        //    }
        //    pictureBox1.Enabled = false;
        //    alphabet_panel.Enabled = true;
        //    tool_panel.Enabled = true;
        //    List<Letter> enabled_letters = alphabet.Where(l => l.Enabled).ToList();
        //    letter_Click(enabled_letters[rand.Next(0, enabled_letters.Count - 1)], EventArgs.Empty);
        //    Thread.Sleep(1000);
        //    alphabet_panel.Enabled = false;
        //    tool_panel.Enabled = false;
        //    pictureBox1.Enabled = true;
        //    Thread.Sleep(1000);
        //}
        //private async Task ComputerMode(Player player)
        //{
        //    status_lb.Text = game.CurrentPlayer.Name + " крутіть колесо";
        //    await Task.Delay(2000);
        //    pictureBox1_Click(pictureBox1, EventArgs.Empty);
        //    status_lb.Text = game.CurrentPlayer.Name + " обирайте літеру";
        //    await Task.Delay(2000);

        //    if (player.Score >= 250)
        //    {
        //        int choice = rand.Next(0, 2); // Виправлено діапазон випадкового вибору
        //        if (choice == 1)
        //        {
        //            BuyVowel();
        //        }
        //    }

        //    pictureBox1.Enabled = false;
        //    alphabet_panel.Enabled = true;
        //    tool_panel.Enabled = true;
        //    List<Letter> enabled_letters = alphabet.Where(l => l.Enabled).ToList();
        //    letter_Click(enabled_letters[rand.Next(0, enabled_letters.Count)], EventArgs.Empty); // Виправлено діапазон випадкового вибору
        //    await Task.Delay(2000);

        //    alphabet_panel.Enabled = false;
        //    tool_panel.Enabled = false;
        //    pictureBox1.Enabled = true;
        //    await Task.Delay(1000);
        //}

        private void UpdateScore(Player player, int index)
        {
            scores[index].Text = "Рахунок: " + player.Score.ToString();
        }
    }
    public class Letter : Button
    {
        private bool is_answer_letter;
        private string current_letter;
        private bool is_vowel;
        private bool is_active;
        public string Current_letter
        {
            get { return current_letter; }
        }
        public bool Active
        {
            get { return is_active; }
            set { is_active = value; }
        }
        public bool Vowel
        {
            get { return is_vowel; }
        }
        public Letter(string l, bool answer_letter)
        {
            if (answer_letter)
            {
                is_answer_letter = true;
                this.BackgroundImage = global::app.Properties.Resources._1676636867_catherineasquithgallery_com_p_zelenie_polosi_fon_9;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.Enabled = false;
            }
            else
            {
                is_answer_letter = false;
                if (l == "Е" || l == "А" || l == "Є" || l == "И" || l == "І" || l == "Ї" || l == "О" || l == "У" || l == "Ю" || l == "Я")
                {
                    is_vowel = true;
                    this.Enabled = false;
                    this.BackColor = Color.Khaki;
                }
                else
                {
                    is_vowel = false;
                    this.BackColor = Color.Gold;
                }
                this.Margin = new Padding(7, 15, 7, 15);
                this.Text = l;
                is_active = true;
            }
            current_letter = l;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Size = new Size(31, 43);
        }
        public void GuessedLetter()
        {
            if (is_answer_letter)
            {
                this.BackgroundImage = null;
                this.BackColor = Color.GhostWhite;
                this.Text = Current_letter;

            }
        }
        public static bool operator ==(Letter first, Letter second)
        {
            return first.Current_letter == second.Current_letter;
        }
        public static bool operator !=(Letter first, Letter second)
        {
            return !(first == second);
        }
    }
}
