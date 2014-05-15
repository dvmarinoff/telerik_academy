using System;
using System.Text;
//03. Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".
class LastDigitWord
{
    static int PrintLastDigit(char digit)
    {
        int result = 0;
        switch (digit)
        {
          
            case '1':
                result = 1;
                break;
            case '2':
                result = 2;
                break;
            case '3':
                result = 3;
                break;
            case '4':
                result = 4;
                break;
            case '5':
                result = 5;
                break;
            case '6':
                result = 6;
                break;
            case '7':
                result = 7;
                break;
            case '8':
                result = 8;
                break;
            case '9':
                result = 9;
                break;
            default: result = 0;
                break;
        }
       
        return result;
    }

    static void Main()
    {
        string number = Console.ReadLine();
        int index = number.Length - 1;
        char lastDigit = number[index];

        Console.WriteLine(PrintLastDigit(lastDigit));
    }
}

