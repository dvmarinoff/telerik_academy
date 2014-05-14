namespace StudentProject
{
    using System;
    using System.Text;

    public class Student :ICloneable, IComparable<Student>
    {
        //Data:
        private string firstName;
        private string middleName;
        private string lastName;
        private string address;
        private string ssn;
        private string mobilePhone;
        private string email;
        private string course;
        public Speciality Speciality { get; private set; }
        public Faculty Faculty { get; private set; }
        public University University { get; private set; }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name must be longer than 2!");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name must be longer than 2!");
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name must be longer than 2!");
                }

                this.lastName = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Address can not be empty!");
                }

                this.address = value;
            }
        }

        public string SSN
        {
            get
            {
                return this.ssn;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("SSN can not be empty!");
                }

                this.ssn = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Mobile phone can not be Empty!");
                }

                this.mobilePhone = value;
            }
        }

        public string EMAIL
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email can not be Empty!");
                }

                this.email = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email can not be Empty!");
                }

                this.course = value;
            }
        }

        //Constructors:
        public Student(string firstName, string middleName, string lastName,
            string ssn, string address, string mobilePhone, string email, 
            string course, University university, Faculty faculty, Speciality speciality)
        { 
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.EMAIL = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Speciality = speciality;
        }

        //Methods:
        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }

            Student student = obj as Student;
            if (student.FirstName != this.FirstName || student.middleName != this.middleName 
                || student.LastName != this.LastName || student.SSN != this.SSN)
            {
                return false;
            }
            
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.SSN.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Student's name is : {0} {1} {2}. ", this.FirstName, this.MiddleName, this.LastName);
            sb.AppendFormat("Student's SSN is : {0}. ", this.SSN);
            sb.AppendFormat("Student's phone is : {0}. ", this.MobilePhone);
            sb.AppendFormat("Student's email is : {0}. ", this.Address);
            sb.AppendFormat("Student is in : {0} course, speciality {1}, faculty {2}, university {3}. ",
                this.Course, this.Speciality, this.Faculty, this.University);
            return sb.ToString();
        }

        public static bool operator ==(Student a, Student b)
        {
            return Student.Equals(a, b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !Student.Equals(a, b);
        }

        public Student Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address,
                this.MobilePhone, this.EMAIL, this.Course, this.University, this.Faculty, this.Speciality);
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName != otherStudent.FirstName)
            {
                return this.FirstName.CompareTo(otherStudent.FirstName);
            }
            if (this.MiddleName != otherStudent.MiddleName)
            {
                return this.MiddleName.CompareTo(otherStudent.MiddleName);
            }
            if (this.LastName != otherStudent.LastName)
            {
                return this.LastName.CompareTo(otherStudent.LastName);
            }
            if (this.SSN != otherStudent.SSN)
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }

            return 0;
        }
    }
}
