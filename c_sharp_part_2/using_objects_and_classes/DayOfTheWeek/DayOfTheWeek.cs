﻿using System;
using System.Collections.Generic;
using System.Linq;
//03. Write a program that prints to the console which day of the week is today. Use System.DateTime.
class DayOfTheWeek
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine("Today is {0}.", today.DayOfWeek);
    }
}

