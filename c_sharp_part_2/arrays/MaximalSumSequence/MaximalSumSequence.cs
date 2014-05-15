using System;
using System.Collections.Generic;
using System.Linq;
//08. Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?

class MaximalSumSequence
{
    static void Main()
    {
        int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 }; 
        int startIndex = 0;
        int tempStartIndex = 0;
        int endIndex = 0;
        int currentSum = numbers[0];
        int maxSum = numbers[0];

        for (int i = 1; i < numbers.Length; i++)    //Kadane's algorithm
        {
            currentSum += numbers[i];
            if (numbers[i] > currentSum)
            {
                currentSum = numbers[i];
                tempStartIndex = i;
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = tempStartIndex;
                endIndex = i;
            }
        }
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }
    }
}

