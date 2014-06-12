using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Greed
{
    public class GameMenu : Print
    {
        private int windowWidthCenter;
        private int windowHeightCenter;
        private MenuItem[] menuItems;
        private string logo;

        public GameMenu(int windowWidth, int windowHeight)
        {
            this.windowWidthCenter = windowWidth / 2;
            this.windowHeightCenter = windowHeight / 2;
            this.menuItems = new MenuItem[] 
            {
               new MenuItem("Play", true), 
               new MenuItem("Score Board", false), 
               new MenuItem("Help", false) ,
               new MenuItem("Exit", false) 
            };

            this.logo = File.ReadAllText(@".\Content\logo.txt");
        }

        public void OnButtonUpPressed()
        {
            int index = 0;
            for (int i = 0; i < this.menuItems.Length; i++)
            {
                if (this.menuItems[i].IsSelected)
                {
                    index = this.ClearSelectedGameMenu(i);
                }
            }

            index--;
            if (index < 0)
            {
                index = this.menuItems.Length - 1;
            }

            this.AddSelectedGameMenu(index);
        }

        public void OnButtonDownPressed()
        {
            int index = 0;
            for (int i = 0; i < this.menuItems.Length; i++)
            {
                if (this.menuItems[i].IsSelected)
                {
                    index = this.ClearSelectedGameMenu(i);
                }
            }

            index++;
            if (index >= this.menuItems.Length)
            {
                index = 0;
            }

            this.AddSelectedGameMenu(index);
        }

        public void PrintGameMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(this.logo);

            for (int i = 0; i < this.menuItems.Length; i++)
            {
                int heightPosition = this.windowHeightCenter + i * 3;
                if (this.menuItems[i].IsSelected)
                {
                    this.AddSelectedGameMenu(i);
                }
                else
                {
                    int widthPosition = this.windowWidthCenter - this.menuItems[i].Value.Length / 2;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    base.PrintOnPosition(widthPosition, heightPosition, this.menuItems[i].Value);
                }
            }
        }

        private void AddSelectedGameMenu(int index)
        {
            this.menuItems[index].IsSelected = true;

            string selectedGameMenu = string.Format(">> {0} <<", this.menuItems[index].Value);
            int widthPosition = this.windowWidthCenter - selectedGameMenu.Length / 2;
            int heightPosition = this.windowHeightCenter + index * 3;

            Console.ForegroundColor = ConsoleColor.White;
            base.PrintOnPosition(widthPosition, heightPosition, selectedGameMenu);
        }

        private int ClearSelectedGameMenu(int index)
        {
            this.menuItems[index].IsSelected = false;

            string selectedGameMenu = string.Format("   {0}   ", this.menuItems[index].Value);
            int widthPosition = this.windowWidthCenter - selectedGameMenu.Length / 2;
            int heightPosition = this.windowHeightCenter + index * 3;
            Console.ForegroundColor = ConsoleColor.Blue;
            base.PrintOnPosition(widthPosition, heightPosition, selectedGameMenu);

            return index;
        }

        internal bool OnButtonEnterPressed()
        {
            bool isPlayModeSelected = false;
            var item = this.menuItems.Where(x => x.IsSelected).FirstOrDefault();

            switch (item.Value)
            {
                case "Play":
                    isPlayModeSelected = true;
                    break;
                case "Score Board":
                    ScoreBoard scoreBoard = new ScoreBoard();
                    List<Score> scores = scoreBoard.ReadAllScores();
                    scoreBoard.PrintOnConsole(scores);
                    break;
                case "Help":
                    Greed.PrintHelp();
                    break;
                case "Exit":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

            return isPlayModeSelected;
        }
    }
}
