using System;
using System.Collections.Generic;
using System.Text;
//04. Write a program that finds the maximal sequence of equal elements in an array.
class Program
{
    static void Main()
    {
        int[] myArray = new int[10];
        int start = myArray[0];
        int sequenceLength = 1;
        //int bestStart = 0;
        for (int i = 0; i < myArray.Length; i++)
        {
            int element = int.Parse(Console.ReadLine());
            myArray[i] = element;
        }

        Console.Write("myArray[] = ");              //Test
        for (int i = 0; i < 10; i++)    
        {
            Console.Write(myArray[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < 10; i++)
        {
            if (i == 9)
            {
                break;
            }
            else if (myArray[i] == myArray[i + 1])
            {
                sequenceLength++;
            }
            else
            {
                start = i;
                sequenceLength = 1;
            }
        }
        Console.WriteLine(sequenceLength);

    }
}

