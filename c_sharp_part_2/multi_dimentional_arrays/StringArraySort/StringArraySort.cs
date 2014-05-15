using System;
using System.Collections.Generic;
using System.Linq;
//05. You are given an array of strings. Write a method that sorts the array by the 
//length of its elements (the number of characters composing them).
class Program
{
    static void SortStrings(string[] arrayOfStrings)
    {
        int length = arrayOfStrings.Length;
        int[] stringsLengths = new int[length];

        for (int i = 0; i < length; i++)
        {
            stringsLengths[i] = arrayOfStrings[i].Length;
        }
        Array.Sort(stringsLengths, arrayOfStrings);

        foreach (var item in arrayOfStrings)
        {
            Console.WriteLine(item);
        }
    }

    static void Main()
    {
        string[] beers = {"Zagorka", "Kamenitza", "Ariana", "Guinness", "Stolichno", "Kaltenberg"};
        //string[] beers = { "abc", "ab", "a", "abcd", "abcde" };
        SortStrings(beers);
    }
}

