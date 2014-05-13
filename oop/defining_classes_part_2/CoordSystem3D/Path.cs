namespace HomeworkDefinigClasses2
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        //Fields:
        private List<Point3D> pathList;

        //Properties:
        public List<Point3D> PathList
        {
            get
            {
                return this.pathList;
            }
            set
            {
                this.pathList = value;
            }
        }

        //Constructors:
        public Path()
        {
            pathList = new List<Point3D>();
        }

        //Methods:
        public void AddPoint(Point3D nextPoint)
        {
            this.pathList.Add(nextPoint);
        }

        public void PrintPath(List<Point3D> path)
        {
            for (int i = 0; i < path.Count; i++)
            {
                Console.WriteLine(path[i].ToString());
            }
        }
    }
}


