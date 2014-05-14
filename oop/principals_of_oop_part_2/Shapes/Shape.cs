namespace Shapes
{
    using System;

    public abstract class Shape
    {
        internal double Width { get; set; }
        internal double Height { get; set; }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();
    }
}
