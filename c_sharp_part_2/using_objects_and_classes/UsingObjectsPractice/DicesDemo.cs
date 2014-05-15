using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingObjectsPractice
{
    public class Player
    {
        private string name;
        private string color;
        private int score;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                this.score = value;
            }
        }
        public Player()
        {
            this.name = "unnamed";
            this.color = "gray";
            this.score = 0;
        }
        public Player(string name, string color, int score)
        {
            this.name = name;
            this.color = color;
            this.score = score;
        }
        public void RollDices()
        {
            Random number = new Random();
            int diceResult = number.Next(1, 6) + number.Next(1, 6);
            score = diceResult;
            Console.WriteLine("Player {0} rolls dices: ... ", name);
            Console.WriteLine("Score: {0}", score);
            //Console.WriteLine("{0} says: I shell win! Hahaha!", name);
        }
        public int KeepScore()
        {
            int totalScore = score;
            return totalScore;
        }

        static void Main()
        {
            Player firstPlayer = new Player();
            firstPlayer.Name = "Pesho";

            Player secondPlayer = new Player();
            secondPlayer.Name = "Pepy";
            while (true)
            {

                ConsoleKeyInfo nextTurn = Console.ReadKey();
                if (nextTurn.Key == ConsoleKey.Enter)
                {
                    firstPlayer.RollDices();
                    secondPlayer.RollDices();

                    Console.WriteLine("Next turn: press Enter...");
                    Console.WriteLine(new string('-', 48));
                }
                else
                {
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("{0} score is {1}", firstPlayer.name, firstPlayer.KeepScore());
                    Console.WriteLine("{0} score is {1}", secondPlayer.name, secondPlayer.KeepScore());
                    return;
                }
            }
        }
    }
}