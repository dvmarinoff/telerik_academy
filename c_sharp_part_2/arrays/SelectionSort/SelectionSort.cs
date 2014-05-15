using System;
//07. Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.
class SelectionSort
{
    static void Main()
    {
        int[] numbers = new int[9] { 18, 1, 2, 7, 5, 8, 4, 9, 3 };

        int length = numbers.Length;

        for (int i = 0; i < length - 1; i++)        
        {
            int smallest = i;                       //assume smallest value index
            for (int j = i + 1; j < length; j++)    //iterate over the unsorted part of the array --> int = i + 1;
            {
                if (numbers[smallest] > numbers[j]) //find actual smallest value index 
                {
                    smallest = j;                   //assaign it
                }
            }
            int swap = numbers[smallest];           //swap indeces
            numbers[smallest] = numbers[i];
            numbers[i] = swap;
        }

        for (int k = 0; k < length; k++)            //print sorted array
        {
            Console.WriteLine(numbers[k]);
        }
    }
}
/*  Selection Sort:
 *  
 *  pros: 1. Simplicity; 2. has performance advantages, where auxiliary memory is limited.
 * 
 *  cons: 1. O(n^2) time complexity(rather slow) for larger input. 
 * 
 *  Conclusion: Use for small input(n<20), when data is not close to being sorted. 
 *  Else use Insertion Sort. Suitable for optimization of recursive sorting algorithms 
 *  like Merge Sort for "small enough" sublists.
 */
