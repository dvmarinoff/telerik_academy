using System;
using System.Text;
//02. Write a program that reads two arrays from the console and compares them element by element
class CompareByElement
{
    static void Main()
    {
        int[] firstArray = new int[10];
        int[] secondArray = new int[10];

        for (int i = 0; i < firstArray.Length; i++)
        {
            int elementFirstArray = int.Parse(Console.ReadLine());
            firstArray[i] = elementFirstArray;
        }
        for (int i = 0; i < secondArray.Length; i++)
        {
            int elementSecondArray = int.Parse(Console.ReadLine());
            secondArray[i] = elementSecondArray;

        }
        for (int i = 0; i < firstArray.Length; i++) //Test
        {
            Console.Write(firstArray[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < 10; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("First array element [{0}] = second array element [{0}]", i);
            }
            else if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("First array element [{0}] < second array element [{0}]", i);
            }
            else if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("First array element [{0}] > second array element [{0}]", i);
            }

        }
    }
}

