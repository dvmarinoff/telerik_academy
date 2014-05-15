using System;
using System.Collections.Generic;
using System.Linq;
//12. Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.
class ArrayOfAlphabet
{
    static void Main()
    {
        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 
            'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        string word = Console.ReadLine();

        word.ToCharArray();

        for (int i = 0; i < alphabet.Length; i++)
        {
            for (int j = 0; j < word.Length; j++)
            {
                if (alphabet[i] == word[j])
                {
                    Console.WriteLine("Letter {0} --> index {1}",alphabet[i], i);
                }
            }
        }
    }
}

