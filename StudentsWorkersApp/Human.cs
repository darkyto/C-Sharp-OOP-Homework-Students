namespace StudentsWorkersApp
{
    using System;
    /*
     * OK=== Define abstract class Human with first name and last name. ===OK
     * OK=== Define new class Student which is derived from Human and has new field – grade.  ===OK
     * OK=== Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay ===OK
     * OK=== and method MoneyPerHour() that returns money earned by hour by the worker. ===OK
     * OK=== Define the proper constructors and properties for this hierarchy.===OK
     * 
     * OK=== Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).===OK
     * OK=== Initialize a list of 10 workers and sort them by money per hour in descending order.===OK
     * 
     * Merge the lists and sort them by first name and last name.
     */
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return firstName; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First Name can not be null or empty string!");
                }
                firstName = value; 
            }
        }
        public string LastName
        {
            get { return lastName; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last Name can not be null or empty string!");
                }
                lastName = value; 
            }
        }

        public override string ToString()
        {
            return string.Format(this.FirstName + " " + this.LastName);
        }
    }
}
