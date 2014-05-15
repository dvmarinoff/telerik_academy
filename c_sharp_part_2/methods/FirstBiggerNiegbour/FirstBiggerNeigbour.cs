using System;
//06. Write a method that returns the index of the first element in array that is 
//bigger than its neighbors, or -1, if there’s no such element.
class FirstBiggerNeigbour
{
    static bool CompareNeigbours(int[] x, int index)
    {
        bool isBigger = (x[index - 1] < x[index]) && (x[index + 1] < x[index]);

        return isBigger;
    }

    static void Main()
    {
        int[] myArray = new int[9] { 1, 2, 4, 5, 4, 7, 1, 8, 1 };

       //code
    }
}

