using System;
using System.Text;
//12. Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
//	N = 3			N = 4
class Program
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());

        if (N > 20)
        {
            Console.WriteLine("Please enter N < 20.");
        }
        else
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    Console.Write((i + j).ToString().PadLeft(3));
                }
                Console.WriteLine();
            }
        }
    }
}

