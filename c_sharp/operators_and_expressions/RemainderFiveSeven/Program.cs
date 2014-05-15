using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemainderFiveSeven
{
    class Program
    {
        //02. Write a boolean expression that checks for given integer if it can be divided
        // (without remainder) by 7 and 5 in the same time.
        static void Main(string[] args)
        {
            //Test Loop
            while (true)
            {
                int x = int.Parse(Console.ReadLine());
                bool isDevisible = (x % 7 == 0) && ( x % 5 == 0);
                Console.WriteLine(isDevisible);
            }
           
        }
    }
}
