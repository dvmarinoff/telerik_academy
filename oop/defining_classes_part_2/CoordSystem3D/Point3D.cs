namespace HomeworkDefinigClasses2
{
    using System;

    public struct Point3D
    {
        //Fields:
        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public int X
        {
            get;
            set;
        }
        public int Y
        {
            get;
            set;
        }
        public int Z
        {
            get;
            set;
        }
        //Properties:
        public static Point3D PointO
        {
            get
            {
                return pointO;
            }
        }
        //Constructors:
        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        //Methods:
        public override string ToString()
        {
            return String.Format("({0},{1},{2})", X, Y, Z);
        }
    }
}


