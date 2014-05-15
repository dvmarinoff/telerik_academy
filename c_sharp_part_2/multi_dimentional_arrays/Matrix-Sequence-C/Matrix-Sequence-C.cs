using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //Data:
        int N = int.Parse(Console.ReadLine());
        int[,] myMatrix = new int[N, N];
        int X = N - 1;
        int Y = 0;
        int nextX;
        int nextY;
        //Logic:
        for (int i = 1; i <= N * N; i++)
        {
            myMatrix[X, Y] = i;
            nextX = X + 1;
            nextY = Y + 1;
            if (nextX == N && nextY != N)
            {
                X = (N - Y - 2);
                Y = 0;
            }
            else if (nextY == N)
            {
                Y = (N - X);
                X = 0;
            }
            else
            {
                X = nextX;
                Y = nextY;
            }
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


