using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class RectangleArea
    {
        //03. Write an expression that calculates rectangle’s area by given width and height.
        static void Main(string[] args)
        {
            float height = float.Parse(Console.ReadLine());
            float width = float.Parse(Console.ReadLine());
            float area = height * width;
            Console.WriteLine(area);
        }
    }
}
