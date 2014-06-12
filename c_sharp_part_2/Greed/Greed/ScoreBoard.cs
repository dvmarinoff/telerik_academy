using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;

namespace Greed
{
    public class ScoreBoard : Print
    {
        private List<Score> scores;

        private string filePath;

        public ScoreBoard()
        {
            this.scores = new List<Score>();
            this.filePath = @".\Content\ScoreBoard.txt";
        }

        public List<Score> ReadAllScores()
        {
            string scoresString = string.Empty;

            try
            {
                scoresString = File.ReadAllText(this.filePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path({0}) was not found.", this.filePath);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
            }
            catch (SecurityException)
            {
                Console.WriteLine("The caller does not have the required permission.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("path specified a file that is read-only.");
                Console.WriteLine("Or This operation is not supported on the current platform.");
                Console.WriteLine("Or path specified a directory");
                Console.WriteLine("Orhe caller does not have the required permission.");
            }

            string[] scoresStringLines = scoresString.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var scoreLine in scoresStringLines)
            {
                string[] atributes = scoreLine.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                int scorePoints = 0;
                int.TryParse(atributes[1].Trim(), out scorePoints);
                Score score = new Score() { PlayerName = atributes[0].Trim(), ScorePoints = scorePoints };
                this.scores.Add(score);
            }

            this.scores = this.scores.OrderByDescending(x => x.ScorePoints).Take(20).ToList();
            return this.scores;
        }

        public void WriteAllScores(List<Score> scores)
        {
            StringBuilder sb = new StringBuilder();
            scores = scores.OrderByDescending(x => x.ScorePoints).ToList();
            foreach (var score in scores)
            {
                sb.AppendLine(score.PlayerName + "-" + score.ScorePoints);
            }

            StreamWriter writeAllScores = new StreamWriter(this.filePath, false);
            try
            {
                using (writeAllScores)
                {
                    writeAllScores.Write(sb.ToString());
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path({0}) was not found.", this.filePath);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
            }
            catch (SecurityException)
            {
                Console.WriteLine("The caller does not have the required permission.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("path specified a file that is read-only.");
                Console.WriteLine("Or This operation is not supported on the current platform.");
                Console.WriteLine("Or path specified a directory");
                Console.WriteLine("Orhe caller does not have the required permission.");
            }


            // File.WriteAllText(@".\Content\ScoreBoard.txt", sb.ToString());
        }

        public void PrintOnConsole(List<Score> scores)
        {
            Console.Clear();
            int horizontalPosition = 0;
            string[] scoreMessages = new string[scores.Count];
            for (int i = 0; i < scores.Count; i++)
            {
                string scoreMesage = scores[i].PlayerName + " - " + scores[i].ScorePoints;
                scoreMessages[i] = scoreMesage;
                if (scoreMesage.Length > horizontalPosition)
                {
                    horizontalPosition = scoreMesage.Length;
                }
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            base.PrintInCenter("Player Scores", 0);
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < scoreMessages.Length; i++)
            {
                base.PrintWithAlignment(scoreMessages[i], i + 2, horizontalPosition);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            base.PrintInCenter("Press \"ESC\" or \"Backspace\" to return to the game menu ...", 28);
        }
    }
}
