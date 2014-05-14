namespace Devidable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Devidable
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 4, 8, 9, 42 , 10, 14, 21, 17};

            var devidableLambda = numbers.Where(x => x % 3 == 0 && x % 7 == 0);

            Console.WriteLine("Lambda: ");
            foreach (var item in devidableLambda)
            {
                Console.WriteLine(item);
            }

            var dividableLINQ =
                from number in numbers
                where number % 3 == 0 && number % 7 == 0
                select number;

            Console.WriteLine("\r\nLINQ: ");
            foreach (var item in dividableLINQ)
            {
                Console.WriteLine(item);
            }
        }
    }
}
