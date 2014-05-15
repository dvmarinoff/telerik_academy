using System;
using System.Text;
//05. Write a boolean expression for finding if the bit 3 
//(counting from 0) of a given integer is 1 or 0.
class ThirdBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int mask = 8;
        bool isOne = (number & mask) > 0;
        Console.WriteLine(isOne);
    }
}

