namespace StudentsWorkersApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Worker : Human
    {
        #region Fields
        private const decimal WorkDays = 5; // five work days in a week

        private decimal weekSalary;
        private int workHoursPerDay;
        #endregion

        #region Constuctors
        public Worker(string fName, string lName, decimal weekSalary, int workHours) 
            :base(fName, lName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHours;
        }
                #endregion
        #region Properties

        public decimal WeekSalary
        {
            get { return weekSalary; }
            private set { weekSalary = value; }
        }
        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            private set { workHoursPerDay = value; }
        }
        #endregion

        #region Methods
        public decimal MoneyPerHour()
        {
            decimal result = 0;

            result = this.WeekSalary / (this.WorkHoursPerDay * WorkDays);

            return Math.Round(result , 2); // rounding to the second digit after the point to have normal HourSalary price
        }
        public override string ToString()
        {
            return string.Format("Worker namë: "
                +this.FirstName+" "
                +this.LastName+"\nWeekly Salary: $"
                +this.WeekSalary+"\nWorking Hours per Day: "
                +this.WorkHoursPerDay + "\nMoney per hour: $"
                +this.MoneyPerHour());
        }
        #endregion
    }
}
