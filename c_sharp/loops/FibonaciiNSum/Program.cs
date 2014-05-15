using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//07. Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        long numFib = 1;
        long firstNumber = -1;
        long secondNumber = 1;

        for (int i = 1; i < N; i++)
        {
            numFib = firstNumber + secondNumber;
            Console.WriteLine(numFib);
            firstNumber = secondNumber;
            secondNumber = numFib;
        }
    }
}

