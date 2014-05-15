using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//03. Write a program that reads from the console a sequence of N integer numbers and returns 
//the minimal and maximal of them.
class Program
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());

        
        int minNum = Int32.MaxValue;
        int maxNum = Int32.MinValue;

        
        for (byte index = 1; index <= n; index++)
        {
            int num = Int32.Parse(Console.ReadLine());

            if (num < minNum)
            {
                minNum = num;
            }

            if (num > maxNum)
            {
                maxNum = num;
            }
        }

        
        Console.WriteLine("{0} {1}", minNum, maxNum);

    }
}

