namespace StudentProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Test
    {
        static void Main()
        {
            Student pesho = new Student("Pesho", "Peshev", "Peshev", "1234567890", "Kaspishan 41", 
                "359883123123", "pesho@kaspichan.com", "Tikwologiq", 
                University.MIT, Faculty.Informatics, Speciality.Computer_Science);

            Console.WriteLine(pesho);

            Student gesho = pesho.Clone() as Student;
        }
    }
}
