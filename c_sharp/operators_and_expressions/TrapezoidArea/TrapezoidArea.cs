using System;
using System.Text;
//08. Write an expression that calculates trapezoid's area by given sides a and b and height h.
class TrapezoidArea
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal h = decimal.Parse(Console.ReadLine());
        decimal area = ((a + b) / 2) * h;
        Console.WriteLine(area);
    }
}

