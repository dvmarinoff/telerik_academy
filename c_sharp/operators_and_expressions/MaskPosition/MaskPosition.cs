using System;
using System.Text;
//10. Write a boolean expression that returns if the bit at position p 
//(counting from 0) in a given integer number v has value of 1. 
//Example: v=5; p=1  false
class MaskPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int result = number & mask;
        result = result >> position;
        Console.WriteLine(result == 1 ? true : false);
    } 
}

