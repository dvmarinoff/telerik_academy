using System;
//09. Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
class MostFrequentNumber
{
    static void Main()
    {
        int[] numbers = new int[13] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int length = numbers.Length;
        
        int best = 0;   //best number of hits.
        int winner = 0;

        for (int i = 0; i < length; i++)    //iterates over the array sets each number to be the current.
        {
            int counter = 0;                //keeps how many times the current number is met.
            int current = numbers[i];
            for (int j = 0; j < length; j++)    //iterates over the array and checks how many times
            {                                   // the current number is met.
                if (numbers[i] == numbers[j])
                {
                    counter++;
                }
            }
            if (counter > best)         //condition for declaring a winner.
            {
                best = counter;
                winner = numbers[i];
            }
        }
        Console.WriteLine(winner);
        Console.WriteLine(best);
    }
}

