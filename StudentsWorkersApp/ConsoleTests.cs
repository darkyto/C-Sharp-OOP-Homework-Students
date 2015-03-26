namespace StudentsWorkersApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ConsoleTests
    {
        static void Main(string[] args)
        {
            Line('=',50);
            Console.WriteLine("Problem 2 : Students and Workers");
            Line('=', 50);

            Student myStudent = new Student("Georgi" , "Ivanov" , 4);
            Console.WriteLine("Test : creating new student");
            Console.WriteLine(myStudent.ToString()); Line('-', 50);

            Worker myWorker = new Worker("Anastasia","Rusalkova" , 250 , 9);
            Console.WriteLine("Test for new worker and his hourly salary");
            Console.WriteLine(myWorker.ToString());
            var hourSalary = myWorker.MoneyPerHour();
            Console.WriteLine("Hour SALARY : ${0:F2}", hourSalary);


            Line('-', 50); Console.WriteLine("Sorting by Grade ascending:");
            List<Student> students = new List<Student>
            {
                new Student("Dragan" , "Vidov" , 4),
                new Student("Maria" , "Petrova" , 6),
                new Student("Nikoleta" , "Gesheva" , 6),
                new Student("Viktor" , "Viktorov" , 2),
                new Student("Georgi" , "Paunov" , 3),
                new Student("Nikolay" , "Ivanov" , 5),
                new Student("Dimityr" , "Petkov" , 5),
                new Student("Vania" , "Zlateva" , 6),
                new Student("Galq" , "Iodanova" , 4),
                new Student("Georgi" , "Ivanov" , 3),
            };

            var sortedByGrade = students.OrderBy(x => x.Grade).ToList();
            PrintStudents(sortedByGrade); Line('-', 50); Console.WriteLine("VARIANT TWO for Sorting by Grade ascending:");

            var sortedVariantTwo = from student in students
                       orderby student.Grade ascending
                       select new
                       {
                           Name = student.FirstName + " " + student.LastName,
                           Grade = student.Grade
                       };

            foreach (var st in sortedVariantTwo)
            {
                Console.WriteLine(st.ToString());
            }
            Line('-', 50); Line('=', 50);
            Console.WriteLine("Sorting the workers by money per hour in descending order");
            Line('-', 50);

            List<Worker> workers = new List<Worker>
            {
                new Worker("Anastasia","Rusalkova" , 250 , 9),
                new Worker("Georg","Willkinson" , 450 , 6),
                new Worker("Viktor","Junghans" , 1200 , 10),
                new Worker("Ilia","Iliev" , 700 , 8),
                new Worker("Pesho","Peshev" , 450 , 8),
                new Worker("Vania","Vaneva" , 400 , 8),
                new Worker("Metodi","Stefanov" , 750 , 9),
                new Worker("Maria","Hristova" , 1250 , 7),
                new Worker("Nikolay","Ananiev" , 620 , 8),
                new Worker("Bridjit","Nikoloff" , 750 , 6),
            };
            // PrintWorkers(workers); // for test

            var sortedByMoneyPerHour = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();
            PrintWorkers(sortedByMoneyPerHour); Line('-',50);

            var merged = new List<Human>();
            merged.AddRange(students);
            merged.AddRange(workers);

            merged = merged.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
            Console.WriteLine("Merging workers and students and sorting them by First and Last name"); Line('-', 50);
            foreach (var person in merged)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
            Line('-', 50);

            var anotherMerge = students.Concat<Human>(workers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList(); // also working as expected
        }
        public static void Line(char symbol , int lenght)
        {
            Console.WriteLine(new string(symbol, lenght));
        }
        public static void PrintStudents(List<Student> students)
        {
            foreach (var st in students)
            {
                Console.WriteLine(st.ToString());
            }
        }
        public static void PrintWorkers(List<Worker> workers)
        {
            foreach (var wr in workers)
            {
                Console.WriteLine(wr.ToString());
                Line('-', 50);
            }
        }
    }
}
