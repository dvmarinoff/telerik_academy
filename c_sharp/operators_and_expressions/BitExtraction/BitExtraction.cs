using System;
using System.Text;
//11. Write an expression that extracts from a given integer i the value of a given bit number b. 
//Example: i=5; b=2  value=1.
class BitExtraction
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int result = number & mask;
        result = result >> position;
        if (result == 1)
        {
            Console.WriteLine(1);
            return;
        }
        else if (result == 0)
        {
            Console.WriteLine(0);
            return;
        }
        Console.WriteLine("Does Not Work!");
    }
}
