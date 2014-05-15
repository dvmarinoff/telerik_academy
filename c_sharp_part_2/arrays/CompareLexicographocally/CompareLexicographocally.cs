using System;
using System.Collections.Generic;
using System.Text;
//03. Write a program that compares two char arrays lexicographically (letter by letter).
class CompareLexicographocally
{
    static void Main()
    {
        char[] firstArray = new char[10];
        char[] secondArray = new char[10];
        //Input:
        for (int i = 0; i < firstArray.Length; i++)
        {
            char elementFirstArray = char.Parse(Console.ReadLine());
            firstArray[i] = elementFirstArray;
        }
        for (int i = 0; i < secondArray.Length; i++)
        {
            char elementSecondArray = char.Parse(Console.ReadLine());
            secondArray[i] = elementSecondArray;

        }
        //Test Print:
        for (int i = 0; i < firstArray.Length; i++) //Test 
        {
            Console.Write(firstArray[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < secondArray.Length; i++) 
        {
            Console.Write(secondArray[i] + " ");
        }
        Console.WriteLine();
        
        //Output:
        for (int i = 0; i < 10; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("First array element {0} = second array element {0}", i);
            }
            else if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("First array element {0} < second array element {0}", i);
            }
            else if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("First array element {0} > second array element {0}", i);
            }
            
        }
    }
}

