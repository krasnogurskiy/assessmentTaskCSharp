using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}



//namespace app
//{
//   // Клас гравця
//    public class Player
//    {
//        public string Name { get; set; }
//        public int Score { get; set; }
//    }

//    // Клас колеса Фортуни
//    public class GameWheel
//    {
//        public void Spin()
//        {
//            // Логіка обертання колеса
//        }

//        public int GetPoints()
//        {
//            // Повертає кількість очків, що випали після обертання колеса
//            return 0;
//        }
//    }

//    // Клас питання
//    public class Question
//    {
//        public string QuestionText { get; set; }
//        public string Answer { get; set; }
//    }

//    // Клас гри
//    public class Game
//    {
//        private int currentPlayerIndex;
//        private int currentRound;
//        private GameWheel gameWheel;

//        public List<Player> Players { get; set; }
//        public List<Question> Questions { get; set; }

//        public Game()
//        {
//            Players = new List<Player>();
//            Questions = new List<Question>();
//            gameWheel = new GameWheel();
//        }

//        public void StartGame()
//        {
//            currentRound = 1;
//            currentPlayerIndex = 0;

//            // Ініціалізуємо стан гри та відображаємо графічний інтерфейс
//            InitializeGame();
//            UI.DisplayGameBoard();

//            // Цикл раундів гри
//            while (currentRound <= 4)
//            {
//                UI.DisplayRound(currentRound);

//                // Отримуємо активного гравця
//                Player currentPlayer = Players[currentPlayerIndex];

//                // Гравець обертає колесо Фортуни
//                gameWheel.Spin();
//                int points = gameWheel.GetPoints();

//                UI.DisplaySpinResult(points);

//                // Гравець вибирає дію (відкриття літери або спробу вгадати повністю)
//                PlayerAction playerAction = UI.GetPlayerAction();

//                if (playerAction == PlayerAction.GuessFullWord)
//                {
//                    string guessedWord = UI.GetPlayerGuess();
//                    HandlePlayerGuess(currentPlayer, guessedWord, points);
//                }
//                else if (playerAction == PlayerAction.OpenLetter)
//                {
//                    //char letter = UI.GetLetterFromPlayer();
//                    HandleOpenLetter(currentPlayer, letter, points);
//                }

//                // Перехід до наступного гравця
//                currentPlayerIndex = (currentPlayerIndex + 1) % Players.Count;

//                // Якщо всі гравці виконали свій хід, переходимо до наступного раунду
//                if (currentPlayerIndex == 0)
//                    currentRound++;
//            }

//            // Гра завершена, відображаємо фінальні результати
//           // UI.DisplayFinalScores(Players);
//        }

//        private void InitializeGame()
//        {
//            // Ініціалізуємо список питань та гравців
//            // ...

//            // Заповнюємо список питань (Questions) з відповідями
//            // ...
//        }

//        private void HandlePlayerGuess(Player player, string guessedWord, int points)
//        {
//            // Перевіряємо, чи відповідає вгадане слово правильній відповіді
//            // ...

//            // Оновлюємо бали гравця та відображаємо інформацію на інтерфейсі
//            // ...

//            // Перехід до наступного гравця
//            NextPlayerTurn();
//        }

//        private void HandleOpenLetter(Player player, char letter, int points)
//        {
//            // Перевіряємо, чи присутня відкрита літера у відповіді
//            // ...

//            // Оновлюємо бали гравця та відображаємо інформацію на інтерфейсі
//            // ...

//            // Перехід до наступного гравця
//            NextPlayerTurn();
//        }

//        private void NextPlayerTurn()
//        {
//            // Перехід до наступного гравця
//            currentPlayerIndex = (currentPlayerIndex + 1) % Players.Count;

//            // Відображення інформації про наступного гравця на інтерфейсі
//            //UI.DisplayNextPlayer(Players[currentPlayerIndex]);
//        }
//    }


//    // Клас графічного інтерфейсу
//    public class UI
//    {
//        public void DisplayMainMenu()
//        {
//            // Відображення головного меню гри
//        }

//        public void DisplayGameBoard()
//        {
//            // Відображення ігрової дошки
//        }

//        public void DisplayQuestion(Question question)
//        {
//            // Відображення питання
//        }

//        public void DisplayPlayerScores(List<Player> players)
//        {
//            // Відображення балів гравців
//        }

//    }

//}
