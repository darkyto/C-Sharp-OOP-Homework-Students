namespace StudentsWorkersApp
{
    using System;

    public class Student : Human
    {
        private double grade;

        public Student(string fName , string lName , int grade)
            : base(fName, lName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get { return grade; }
            private set { grade = value; }
        }

        public override string ToString()
        {
            return string.Format("Student name: "+this.FirstName + " "+this.LastName +"\nCurrent Grade: "+this.Grade);
        }
    }
}
