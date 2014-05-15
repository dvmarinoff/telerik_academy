using System;
using System.Collections.Generic;
//08. Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.
class ArrayNumbers
{
    static void AddNumbers(int[] firstNum, int[] secondNum)
    {
        List<int> result = new List<int>(5);
        bool carry = false;
        int digit;
        for (int i = 0; i < 5; i++)
        {
            
            
            if (carry)
            {
                digit = firstNum[i] + secondNum[i] + 1;
            }
            else
            {
                digit = firstNum[i] + secondNum[i];
                Console.WriteLine("digit = {0}", digit);
            }

            if (digit > 9)
            {
                carry = true;
                digit = digit % 10;
                Console.WriteLine("digit > 9 = {0}", digit);
            }
            result[i] = digit;

        }
        PrintResult(result);
    }
    static void PrintResult(List<int> x)
    {
        for (int i = 0; i < x.Count; i++)
        {
            Console.WriteLine(x[i]);
        }
    }
    static void Main()
    {
        int[] firstNumber = new int[] { 5, 4, 3, 2, 1 };
        int[] secondNumber = new int[] { 5, 4, 3, 2, 1 };

        AddNumbers(firstNumber, secondNumber);
    }
}

