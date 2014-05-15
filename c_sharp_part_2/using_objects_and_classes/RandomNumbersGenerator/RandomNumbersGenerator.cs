using System;
using System.Collections.Generic;
using System.Text;
//02. Write a program that generates and prints to the console 10 random values in the range [100, 200].
class RandomNumbersGenerator
{
    static void Main()
    {
        Random numbers = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0}",numbers.Next(100, 201));
        }
        
    }
}

