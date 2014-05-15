using System;
using System.Collections.Generic;
using System.Numerics;
//10. Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter n! - from 0 to 100: ");
        int n = int.Parse(Console.ReadLine());

        FactorialCalculation(n);

    }

    private static void FactorialCalculation(int n)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("{0}! = {1}", n, factorial);
    }
}

