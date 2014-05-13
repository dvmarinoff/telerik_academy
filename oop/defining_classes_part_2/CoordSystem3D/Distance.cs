namespace HomeworkDefinigClasses2
{
    using System;

    public static class Distance
    {
        public static double CalculateDistance(Point3D first, Point3D second)
        {
            return Math.Sqrt(((first.X - second.X) * (first.X - second.X)) + ((first.Y - second.Y) * (first.Y - second.Y)) + ((first.Z - second.Z) * (first.Z - second.Z)));
        }
    }
}



