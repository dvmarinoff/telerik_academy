using System;
//01. Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
class Program
{
    static void Main(string[] args)
    {
        int[,] myMatrix = new int[4, 4];
        int i = 1;

        for (int col = 0; col < myMatrix.GetLength(0); col++)
        {
            for (int row = 0; row < myMatrix.GetLength(1); row++)
            {
                myMatrix[row, col] = i;
                i++;
            }
        }

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
