using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class OddOrEven
    {
        //01. Write an expression that checks if given integer is odd or even.

        //static void Main()
        //{
        //    int x = int.Parse(Console.ReadLine());
        //    if ((x % 2) == 0)
        //    {
        //        Console.WriteLine("{0} is even.", x);
        //    }
        //    else 
        //    {
        //        Console.WriteLine("{0} is odd.",x);
        //    }
        //}
        //Using bitwise operation.
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int mask = 1;
            bool isEven = (number & mask) == 0;
            Console.WriteLine(isEven);
        }
    }
}
