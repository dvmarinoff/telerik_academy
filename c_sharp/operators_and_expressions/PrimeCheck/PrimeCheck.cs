using System;
using System.Text;
//07. Write an expression that checks if given positive integer number 
//n (n ≤ 100) is prime. E.g. 37 is prime.
class PrimeCheck
{
    static void Main()
    {
        //Make use of check till square root of 100.
        int number = int.Parse(Console.ReadLine());
        bool isPrime = (number % 2 > 0) || (number % 3 > 0) || (number % 5 > 0) || (number % 7 > 0);
        bool isOneDigit = (number == 2) && (number == 3) && (number == 5) && (number == 7);
        Console.WriteLine(isPrime || isOneDigit);
    }
}

