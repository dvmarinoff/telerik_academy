using System;

class Program
{
    /// <summary>
    /// columns are divided in two types: odd and even, the colCount variable
    /// keeps track of this. Depending on it's value the i variable(used for storing the 
    /// values for each cell in the matrix) is decremented or incremented.
    /// A formula is used for calculating the starting value of i in each column.
    /// i += N - 1; --> even columns, and i += N + 1; --> odd columns. 
    /// A rather ugly code, but it seems to work.
    /// </summary>
    static void Main()
    {
        //Data:
        int N = int.Parse(Console.ReadLine());
        int[,] myMatrix = new int[N, N];
        int i = 1;
        int colCount = 1;
        //Logic:
        for (int col = 0; col < myMatrix.GetLength(0); col++)
        {
            if (colCount % 2 == 0)                      //every even column.
            {
                i += N - 1;
                for (int row = 0; row < myMatrix.GetLength(1); row++)
                {
                    myMatrix[row, col] = i;
                    i--;
                }
            }
            else if (colCount == 1)                     //first column only.
            {
                for (int row = 0; row < myMatrix.GetLength(1); row++)
                {
                    myMatrix[row, col] = i;
                    i++;
                }
            }
            else                                       //every other odd column.
            {
                i += N + 1;
                for (int row = 0; row < myMatrix.GetLength(1); row++)
                {
                    myMatrix[row, col] = i;
                    i++;
                }
            }
            colCount++;
        }
        //Print:
        for (int row = 0; row < myMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < myMatrix.GetLength(1); col++)
            {
                Console.Write(myMatrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

