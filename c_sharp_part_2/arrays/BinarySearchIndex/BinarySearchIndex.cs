using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// 11. Write a program that finds the index of given element in a sorted array of integers by 
//using the binary search algorithm (find it in Wikipedia).
class BinarySearchIndex
{

    static void Main()
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 19, 23, 34 };
        int length = numbers.Length;
        int key = 12;
        int middle = 0;
        int start = 0;
        int end = length - 1;

        while (start <= end)
        {
            middle = (start + end) / 2;

            if (numbers[middle] == key)
            {
                Console.WriteLine("The index of number {0} is {1}", numbers[middle], middle);
                break;
            }
            if (key < numbers[middle])
            {
                end = middle - 1;
            }
            if (key > numbers[middle])
            {
                start = middle + 1;
            }
        }

    }
}
