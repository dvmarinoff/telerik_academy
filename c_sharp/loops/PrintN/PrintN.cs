using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//01. Write a program that prints all the numbers from 1 to N.
class Program
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());

        for (int i = 1; i < n + 1; i++)
        {
            Console.WriteLine(i);
        }
    }
}

