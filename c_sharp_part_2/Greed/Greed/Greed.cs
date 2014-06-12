using System;

namespace Greed
{
    public static class Greed
    {
        //Warning! Set console properties to font - Lucida Console 18pt. In that way we will se the exact thing.
        static int windowHeight = 30;
        static int windowWidth = 80;
        static int bufferZone = 5;
        static int matriceHeight = windowHeight - bufferZone;
        static int matriceWidth = windowWidth;
        static int[,] gameField = new int[matriceHeight, matriceWidth];
        static int score = 1;
        static int currentX;
        static int currentY;

        static void GenerateGameField()
        {
            Random randomGenerator = new Random();

            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                for (int col = 0; col < gameField.GetLength(1); col++)
                {
                    gameField[row, col] = randomGenerator.Next(1, 10);
                }
            }
        }

        static void PrintGameField()
        {
            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                for (int col = 0; col < gameField.GetLength(1); col++)
                {
                    Console.ForegroundColor = GetColor(gameField[row, col]);

                    Console.Write(gameField[row, col]);

                    Console.ResetColor();
                }
            }
        }

        static ConsoleColor GetColor(int number)       //Returns color for every single digit. Everytime the same color.
        {
            switch (number)
            {
                case 0:
                    {
                        return ConsoleColor.Black;
                    }
                case 1:
                    {
                        return ConsoleColor.Blue;
                    }
                case 2:
                    {
                        return ConsoleColor.Cyan;
                    }
                case 3:
                    {
                        return ConsoleColor.Magenta;
                    }
                case 4:
                    {
                        return ConsoleColor.DarkCyan;
                    }
                case 5:
                    {
                        return ConsoleColor.Gray;
                    }
                case 6:
                    {
                        return ConsoleColor.DarkMagenta;
                    }
                case 7:
                    {
                        return ConsoleColor.Green;
                    }
                case 8:
                    {
                        return ConsoleColor.DarkRed;
                    }
                case 9:
                    {
                        return ConsoleColor.Yellow;
                    }
                default:
                    {
                        return ConsoleColor.Gray;
                    }
            }
        }

        static void PrintOnPosition(int x, int y, string message)
        {
            Console.SetCursorPosition(y, x);

            Console.Write(message);
        }

        static void PrintInfo()
        {
            double percentage = score * 100.0 / ((windowHeight - bufferZone) * windowWidth);       //If someone don't understand this formula contact Aleksandar Dimitrov

            PrintOnPosition(windowHeight - 3, 2, string.Format("Score: {0} {1}%", score, percentage));

            PrintOnPosition(windowHeight - 3, windowWidth - 20, "Press F1 for help.");
        }

        public static void PrintHelp()
        {
            int verticalPosition = 5;
            Console.Clear();
            PrintInCenter("Wellcome to Help menu!", verticalPosition++);
            PrintInCenter("Controls:", verticalPosition++);
            PrintInCenter("Q W E", verticalPosition++);
            PrintInCenter("A   D", verticalPosition++);
            PrintInCenter("Z X C", verticalPosition++);
            PrintInCenter("Press \"h\" to turn on help.", verticalPosition++);
            PrintInCenter("Press \"r\" to restart game.", verticalPosition++);
            PrintInCenter("Press \"t\" for high scores.", verticalPosition++);
            Console.WriteLine();
            PrintInCenter("Press \"Esc\" to return to the game.", verticalPosition++);
        }

        static void PrintInCenter(string message, int verticalPosition)
        {
            int horisontalPosition = (windowWidth - message.Length) / 2;

            PrintOnPosition(verticalPosition, horisontalPosition, message);
        }

        static void SetPlayerFirstPosition()
        {
            //Set on random first position of the '@' - player
            Random ranPlayerCoordes = new Random();

            //Set x and y coordes of the '@' - player
            int xCoordes = ranPlayerCoordes.Next(0, (windowHeight - bufferZone));
            int yCoordes = ranPlayerCoordes.Next(0, windowWidth);

            //Set current position
            currentX = xCoordes;
            currentY = yCoordes;

            //Set current position as eaten
            gameField[xCoordes, yCoordes] = 0;

            //Set player fist position
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            PrintOnPosition(xCoordes, yCoordes, "@");
            Console.ResetColor();
        }

        static bool isNotCrossingEatenField(string pressedKey)
        {
            bool isNotCrossing = true;
            int length;

            switch (pressedKey)
            {
                case "A":
                    length = gameField[currentX, currentY - 1];

                    for (int i = 1; i <= length; i++)
                    {
                        if (gameField[currentX, currentY - i] == 0)
                        {
                            isNotCrossing = false;
                            break;
                        }
                    }
                    break;
                case "D":
                    length = gameField[currentX, currentY + 1];

                    for (int i = 1; i <= length; i++)
                    {
                        if (gameField[currentX, currentY + i] == 0)
                        {
                            isNotCrossing = false;
                            break;
                        }
                    }
                    break;
                case "W":
                    length = gameField[currentX - 1, currentY];

                    for (int i = 1; i <= length; i++)
                    {
                        if (gameField[currentX - i, currentY] == 0)
                        {
                            isNotCrossing = false;
                            break;
                        }
                    }
                    break;
                case "S":
                    length = gameField[currentX + 1, currentY];

                    for (int i = 1; i <= length; i++)
                    {
                        if (gameField[currentX + i, currentY] == 0)
                        {
                            isNotCrossing = false;
                            break;
                        }
                    }
                    break;
                case "Q":
                    length = gameField[currentX - 1, currentY - 1];

                    for (int row = 1, col = 1; row <= length; row++, col++)
                    {
                        if (gameField[currentX - row, currentY - col] == 0)
                        {
                            isNotCrossing = false;
                            break;
                        }
                    }
                    break;
                case "E":
                    length = gameField[currentX - 1, currentY + 1];

                    for (int row = 1, col = 1; row <= length; row++, col++)
                    {
                        if (gameField[currentX - row, currentY + col] == 0)
                        {
                            isNotCrossing = false;
                            break;
                        }
                    }
                    break;
                case "Z":
                    length = gameField[currentX + 1, currentY - 1];

                    for (int row = 1, col = 1; row <= length; row++, col++)
                    {
                        if (gameField[currentX + row, currentY - col] == 0)
                        {
                            isNotCrossing = false;
                            break;
                        }
                    }
                    break;
                case "C":
                    length = gameField[currentX + 1, currentY + 1];

                    for (int row = 1, col = 1; row <= length; row++, col++)
                    {
                        if (gameField[currentX + row, currentY + col] == 0)
                        {
                            isNotCrossing = false;
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }

            return isNotCrossing;
        }

        static bool isValidMovement(string pressedKey)
        {
            bool isValid = false;
            int downFrame = windowHeight - bufferZone;

            switch (pressedKey)
            {
                case "A":
                    //Check if these steps are not greater then frame size
                    isValid = currentY - 1 >= 0 && (currentY - gameField[currentX, currentY - 1] >= 0) ? true : false;
                    //Check if movement will be greater or equal to the frame && next number is not blank
                    isValid = isValid && gameField[currentX, currentY - 1] != 0;
                    break;
                case "D":
                    isValid = currentY + 1 <= windowWidth && (currentY + gameField[currentX, currentY + 1] <= windowWidth) ? true : false;
                    isValid = isValid && gameField[currentX, currentY + 1] != 0;
                    break;
                case "W":
                    isValid = currentX - 1 >= 0 && (currentX - gameField[currentX - 1, currentY] >= 0) ? true : false;
                    isValid = isValid && gameField[currentX - 1, currentY] != 0;
                    break;
                case "S":
                    isValid = currentX + 1 <= downFrame && (currentX + gameField[currentX + 1, currentY] <= downFrame) ? true : false;
                    isValid = isValid && gameField[currentX + 1, currentY] != 0;
                    break;
                case "Q":
                    isValid = currentX - 1 >= 0 && currentY - 1 >= 0 ? true : false;
                    isValid = isValid && (currentX - gameField[currentX - 1, currentY - 1] >= 0) && (currentY - gameField[currentX - 1, currentY - 1] >= 0);
                    isValid = isValid && gameField[currentX - 1, currentY - 1] != 0;
                    break;
                case "E":
                    isValid = currentX - 1 >= 0 && currentY + 1 <= windowWidth ? true : false;
                    isValid = isValid && (currentX - gameField[currentX - 1, currentY + 1] >= 0) && (currentY + gameField[currentX - 1, currentY + 1] >= 0);
                    isValid = isValid && gameField[currentX - 1, currentY + 1] != 0;
                    break;
                case "Z":
                    isValid = currentX + 1 <= downFrame && currentY - 1 >= 0 ? true : false;
                    isValid = isValid && (currentX + gameField[currentX + 1, currentY - 1] <= downFrame) && (currentY - gameField[currentX + 1, currentY - 1] >= 0);
                    isValid = isValid && gameField[currentX + 1, currentY - 1] != 0;
                    break;
                case "C":
                    isValid = currentX + 1 <= downFrame && currentY + 1 <= windowWidth ? true : false;
                    isValid = isValid && (currentX + gameField[currentX + 1, currentY + 1] <= downFrame) && (currentY + gameField[currentX + 1, currentY + 1] <= windowWidth);
                    isValid = isValid && gameField[currentX + 1, currentY + 1] != 0;
                    break;
                default:
                    break;
            }
            if (isValid)
            {
                isValid = isNotCrossingEatenField(pressedKey);
            }

            return isValid;
        }

        static bool isGameOver()
        {
            bool gameOver = true;

            string[] allMoves = { "Z", "C", "A", "S", "D", "Q", "W", "E" };
            bool[] isEveryMoveValidArray = { true, true, true, true, true, true, true, true };

            for (int i = 0; i < allMoves.Length; i++)
            {
                isEveryMoveValidArray[i] = isValidMovement(allMoves[i]);
            }

            foreach (var move in isEveryMoveValidArray)
            {
                if (move)
                {
                    gameOver = false;
                    break;
                }
            }

            return gameOver;
        }

        static void Move(string pressedKey)
        {
            if (isValidMovement(pressedKey))
            {
                //Holds number from chosen position
                int length = 0;
                PrintOnPosition(currentX, currentY, " ");
                switch (pressedKey)
                {
                    case "A":
                        length = gameField[currentX, currentY - 1];
                        for (int i = 1; i <= length; i++)
                        {
                            gameField[currentX, currentY - i] = 0;
                            PrintOnPosition(currentX, currentY - i, " ");
                        }
                        currentY -= length;
                        break;
                    case "D":
                        length = gameField[currentX, currentY + 1];
                        for (int i = 1; i <= length; i++)
                        {
                            gameField[currentX, currentY + i] = 0;
                            PrintOnPosition(currentX, currentY + i, " ");
                        }
                        currentY += length;
                        break;
                    case "W":
                        length = gameField[currentX - 1, currentY];
                        for (int i = 1; i <= length; i++)
                        {
                            gameField[currentX - i, currentY] = 0;
                            PrintOnPosition(currentX - i, currentY, " ");
                        }
                        currentX -= length;
                        break;
                    case "S":
                        length = gameField[currentX + 1, currentY];
                        for (int i = 1; i <= length; i++)
                        {
                            gameField[currentX + i, currentY] = 0;
                            PrintOnPosition(currentX + i, currentY, " ");
                        }
                        currentX += length;
                        break;
                    case "Q":
                        length = gameField[currentX - 1, currentY - 1];
                        for (int row = 1, col = 1; row <= length; row++, col++)
                        {
                            gameField[currentX - row, currentY - col] = 0;
                            PrintOnPosition(currentX - row, currentY - col, " ");
                        }
                        currentX -= length;
                        currentY -= length;
                        break;
                    case "E":
                        length = gameField[currentX - 1, currentY + 1];
                        for (int row = 1, col = 1; row <= length; row++, col++)
                        {
                            gameField[currentX - row, currentY + col] = 0;
                            PrintOnPosition(currentX - row, currentY + col, " ");
                        }
                        currentX -= length;
                        currentY += length;
                        break;
                    case "Z":
                        length = gameField[currentX + 1, currentY - 1];
                        for (int row = 1, col = 1; row <= length; row++, col++)
                        {
                            gameField[currentX + row, currentY - col] = 0;
                            PrintOnPosition(currentX + row, currentY - col, " ");
                        }
                        currentX += length;
                        currentY -= length;
                        break;
                    case "C":
                        length = gameField[currentX + 1, currentY + 1];
                        for (int row = 1, col = 1; row <= length; row++, col++)
                        {
                            gameField[currentX + row, currentY + col] = 0;
                            PrintOnPosition(currentX + row, currentY + col, " ");
                        }
                        currentX += length;
                        currentY += length;
                        break;
                    default:
                        break;
                }

                score += length;

                //Set player colors
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;

                PrintOnPosition(currentX, currentY, "@");

                Console.ResetColor();

                PrintInfo();

                Console.SetCursorPosition(currentY, currentX);

                //Here will be a method called isGameOver
                
            }
        }

        static void Main()
        {
            Console.WindowHeight = windowHeight;
            Console.WindowWidth = windowWidth;
            Console.BufferHeight = Console.WindowHeight;      //Remove scrollbar
            Console.BufferWidth = Console.WindowWidth;        //Remove scrollbar

            InitializeGameMenu();
            GenerateGameField();
            PrintGameField();
            SetPlayerFirstPosition();
            PrintInfo();

            bool isPlaying = true;
            while (isPlaying)
            {
                //Set cursor on the start position
                Console.SetCursorPosition(currentY, currentX);
                //Read direction - Z C  A S D  Q W E
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                Move(pressedKey.Key.ToString());

                // ToDo: if no more posible moves set isPlaying = false
                // isPlaying = false;
                if (isGameOver())
                {
                    PrintInCenter("GAME OVER\n", 23);
                    return;
                }
            }

            Console.WriteLine();
        }

        private static void InitializeGameMenu()
        {
            GameMenu gameMenu = new GameMenu(windowWidth, windowHeight);
            gameMenu.PrintGameMenu();

            bool isPlayModeSelected = false;
            do
            {
                Console.SetCursorPosition(windowWidth - 2, windowHeight - 2);
                var consoleKey = Console.ReadKey();

                switch (consoleKey.Key)
                {
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        gameMenu.OnButtonDownPressed();
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        gameMenu.OnButtonUpPressed();
                        break;
                    case ConsoleKey.Enter:
                        isPlayModeSelected = gameMenu.OnButtonEnterPressed();
                        break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.Backspace:
                        Console.Clear();
                        gameMenu.PrintGameMenu();
                        break;
                    default:
                        break;
                }

            } while (!isPlayModeSelected);

            Console.Clear();
        }
    }
}