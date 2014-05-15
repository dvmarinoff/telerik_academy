using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class ListTDrill
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(i);
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        numbers[3] = 54;
        numbers.Remove(7);

        Console.WriteLine(numbers.Min());
        Console.WriteLine(numbers.Average());

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

