using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//06. Write a program that, for a given two integer numbers N and X, 
//calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int X = int.Parse(Console.ReadLine());

        int i = 1;
        double sum = 1;
        double factorialN = 1;
        do
        {
            for (int j = i; j > 0; j--)
            {
                factorialN *= j;
            }
            sum = factorialN / (X * i);
            i++;
        } while (i <= N);
        Console.WriteLine(sum + 1);
    }
}

