using System;
//05. Write a method that checks if the element at given position in given array of integers 
//is bigger than its two neighbors (when such exist). |
class NeigbourComparer
{
    static bool CompareNeigbours(int[] x, int index)
    {
        bool isBigger = (x[index - 1] < x[index]) && (x[index + 1] < x[index]);

        return isBigger;
    }

    static void Main()
    {
        int[] myArray = new int[9] { 1, 2, 4, 5, 4, 7, 1, 8, 1 }; // index = 3, 5, 7 --> true
        int position = int.Parse(Console.ReadLine());

        if (position < 1 || position == myArray.Length - 1)
        {
            Console.WriteLine("Index Out Of Range...");
            return;
        }

        Console.WriteLine(CompareNeigbours(myArray, position));
    }
}

