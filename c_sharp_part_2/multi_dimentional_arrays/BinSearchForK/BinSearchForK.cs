using System;
//04. Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
class Program
{
    /// <summary>
    /// Not finished.
    ///
    /// </summary>
    static void Main()
    {
        int[] numbers = new int[] { 8, 4, 15, 23, 16, 42 };
        int k = 2;
        Array.Sort(numbers);

        int index = Array.BinarySearch(numbers, k);

        Console.WriteLine("K = {0}", k);

        while (true)
        {
            if (index < 0)
            {
                --k;
                index = Array.BinarySearch(numbers, k);
            }
            else if (index <= k)
            {
                Console.WriteLine(" Element <= k is {0}", numbers[index]); 
                break;
            }
            else
            {
                Console.WriteLine("does not exist"); 
                break;
            }
        }
    }
}

