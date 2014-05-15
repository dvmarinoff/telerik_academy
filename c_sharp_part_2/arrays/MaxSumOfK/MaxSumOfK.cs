using System;
using System.Collections.Generic;
using System.Text;
//06. Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.
class MaxSumOfK
{
    static void Main()
    {
        //Input:
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());

        int[] myArray = new int[N];
        int counterK = 0;
        int sum = 0;

        for (int i = 0; i < N; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }

        //Solution:
        Array.Sort(myArray);
        for (int i = N - 1; i >= 0; i--)
        {
            if (counterK == K)
            {
                Console.WriteLine("Sum of K = {0}",sum);
                break;
            }
            else
            {
                Console.WriteLine("K element = {0}",myArray[i]);
                sum += myArray[i]; 
            }
            counterK++;
        }
    }
}

