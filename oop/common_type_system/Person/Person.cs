namespace PersonProject
{
    using System;
    using System.Text;

    public class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        
        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age)
            : this(name, null)
        { 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Person's name is {0} and ", this.Name);
            if (this.Age == null)
            {
                sb.Append("Person's age is unspecified.");
            }
            else
            {
                sb.AppendFormat("Person's age is {0}.", this.Age);
            }
            return sb.ToString();
        }
    }
}
