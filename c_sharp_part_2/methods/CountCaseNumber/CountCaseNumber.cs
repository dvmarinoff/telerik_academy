using System;
using System.Text;
//04. Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.
class CountCaseNumber
{
    static int CountNumber(int[] x, int num)
    {
        int result = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (num == x[i])
            {
                result++;
            }
        }
        
        return result;
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] myArray = new int[9] { 1, 2, 4, 5, 4, 7, 1, 8, 1 }; // 1 --> 3 or 4 --> 2 
        
        Console.WriteLine(CountNumber(myArray, number));
    }
}

