namespace HomeworkDefinigClasses2
{
    using System;

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Point3D right = new Point3D(10, 0, 0);

            Console.WriteLine(right.ToString());

            Console.WriteLine(Point3D.PointO);

            Console.WriteLine(Distance.CalculateDistance(right, Point3D.PointO));
        }
    }
}
