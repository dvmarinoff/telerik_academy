namespace StudentsLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Queries
    {
        static void Main(string[] args)
        {
            Student[] studentsArray = new Student[]
            {
                new Student("Pesho","Peshev", 20),
                new Student("Ara","Bareva",21),
                new Student("Ivan","Jivanov",22),
                new Student("Joro","Arev",23),
                new Student("Bai","Stamat",24),
            };
            //03:
            Console.WriteLine("First name before Last name: ");

            var firstBeforeLast =
                from student in studentsArray
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            foreach (var item in firstBeforeLast)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            //04:
            Console.WriteLine("\r\nAge Query: ");

            var ageQuery =
                from student in studentsArray
                where student.Age > 19 && student.Age < 24
                select student;

            foreach (var item in ageQuery)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            //05:
            Console.WriteLine("\r\nSort with Lamda: ");

            var SortStudentsLambda =
               studentsArray.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            foreach (var item in SortStudentsLambda)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine("\r\nSort with LINQ: ");
            var SortStudentsLINQ =
                            from student in studentsArray
                            orderby student.FirstName descending, student.LastName descending
                            select student;

            foreach (var item in SortStudentsLINQ)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
