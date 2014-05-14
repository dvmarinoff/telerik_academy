namespace Shapes
{
    using System;
    using System.Collections.Generic;

    class TestShape
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {
                                 new Triangle(5,5),
                                 new Rectangle(5,5),
                                 new Circle(5,5)
                             };

            foreach (var shape in shapes)
            {
                Console.Write(shape.GetType());
                Console.Write(", surface: ");
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
