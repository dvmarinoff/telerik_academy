using System;
using System.Collections.Generic;
using System.Text;
//01. Write a program that allocates array of 20 integers and initializes each 
//element by its index multiplied by 5. Print the obtained array on the console.
    class IndexTimesFive
    {
        static void Main()
        {
            int[] myArray = new int[20];
            for (int i = 0; i < myArray.Length; i++)
			{
			    Console.WriteLine(myArray[i] = i * 5);
			}
        }
    }

