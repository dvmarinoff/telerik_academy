using System;
using System.Text;
//09. Write an expression that checks for given point (x, y) if it is within 
//the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
class PointCheck
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        int radius = 3;
        
        bool isInRectangle = false;
        bool isInCircle = (((X - 1) * (X - 1)) + ((Y - 1) * (Y - 1))) < (radius * radius);
        bool isInCircleOutOfRectagle = isInCircle && !isInRectangle;
        Console.WriteLine(isInCircleOutOfRectagle);
    }
}
