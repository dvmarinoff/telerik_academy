using System;
using System.Text;
//06. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
class PointInCircle
{
    static void Main()
    {
        //The circle is centered at the Coordinate System.
        decimal X = decimal.Parse(Console.ReadLine());
        decimal Y =decimal.Parse(Console.ReadLine());
        decimal radius = 5;
        bool isInside = (X * X) + (Y * Y) <= (radius * radius);
        Console.WriteLine(isInside);
    }
}

