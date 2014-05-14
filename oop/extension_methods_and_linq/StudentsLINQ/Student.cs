namespace StudentsLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Student
    {
        public string FirstName { get;  set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string studentFirstName, string studentLastName, int studentAge)
        {
            this.FirstName = studentFirstName;
            this.LastName = studentLastName;
            this.Age = studentAge;
        }


    }
}
