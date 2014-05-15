using System;
using System.Collections.Generic;
using System.Text;
//01. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
class LeapYear
{
    static void Main()
    {
        Console.Write("Enter an year: ");
        int year = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("The year {0} is leap.", year);
        }
        else
        {
            Console.WriteLine("The year {0} is not leap.", year);
        }
    }
}

