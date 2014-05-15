using System;
using System.Text;
//02. Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
class Program
{


    static int GetMax(int x, int y)
    {
        int result = Math.Max(x, y);
        return result;
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(GetMax(a, b), GetMax(b, c)));
    }
}

