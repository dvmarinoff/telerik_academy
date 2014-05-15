using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class ThirdDigit
    {
        //04. Write an expression that checks for given integer if its third digit
        //(right-to-left) is 7. E. g. 1732  true.
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isSeven = (number / 100) % 10 == 7;
            Console.WriteLine(isSeven);
        }
    }
}
