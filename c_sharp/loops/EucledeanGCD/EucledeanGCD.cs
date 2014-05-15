using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//08. Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
//Use the Euclidean algorithm (find it in Internet).
class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        while (firstNumber != 0 && secondNumber != 0)
        {
            if (firstNumber > secondNumber)
            {
                firstNumber %= secondNumber;
            }
            else
            {
                secondNumber %= firstNumber;
            }
        }
        if (firstNumber == 0)
        {
            Console.WriteLine(secondNumber);
        }
        else
        {
            Console.WriteLine(firstNumber);
        }
    }
}

