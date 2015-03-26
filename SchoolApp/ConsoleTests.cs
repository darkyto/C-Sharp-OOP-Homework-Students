namespace SchoolApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ConsoleTests
    {
        static void Main(string[] args)
        {
            Line('=', 50);
            Console.WriteLine("   The console test program for task \"SCHOOL\""); 
            Line('=',50);

            List<Discipline> sampleDiscplines = new List<Discipline>
            {
                new Discipline("Artificial Neuron Networks", 5, 1),
                new Discipline("Machine Learning", 4, 2, "Advanced displine"), // added comment
                new Discipline("C# Fundamentals" , 14 , 4),
                new Discipline("C# OOP" , 8 , 3),
                new Discipline("JavaScrip NEXT" , 6 , 2),
                new Discipline("Python Fundamentals" , 7 , 0 , "For newbies"), // added comment
                new Discipline("HTML and CSS for Web" , 5 , 2)
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher("John Smith", new List<Discipline>{sampleDiscplines[0] , sampleDiscplines[2]}),
                new Teacher("Ashton Opperhaimer", new List<Discipline>{sampleDiscplines[0] , sampleDiscplines[1], sampleDiscplines[2], sampleDiscplines[4]}),
                new Teacher("Wu Ling Ki", new List<Discipline>{sampleDiscplines[4] , sampleDiscplines[5]}),
                new Teacher("Petur Petrov", new List<Discipline>{sampleDiscplines[4] , sampleDiscplines[2]}),
                new Teacher("Ivan Ivanov", new List<Discipline>{sampleDiscplines[5] , sampleDiscplines[6] , sampleDiscplines[2] , sampleDiscplines[0] })
            };
            Console.WriteLine("All teachers : \n{0}", Print(teachers));

            List<Student> students = new List<Student>
            {
                new Student("Hans Grubelar" , 452852),
                new Student("Maria Petrova" , 245178),
                new Student("Kim ir Sen" ,    214578),
                new Student("Bai Dragan" , 142587),
                new Student("Viktoria Vodenicharova" , 586974),
                new Student("Ahmed Ahmedov" , 111111)
            };

            School mySchool = new School("Telerik Academy"); Console.WriteLine();
            Console.WriteLine("School name : {0}",mySchool.Name); Line('=', 50);

            Teacher biologyTeacher = new Teacher("Jupacabra Smith", sampleDiscplines);
            Console.WriteLine("New teacher : {0}", biologyTeacher.Name); Line('-', 50);
            Student studentTest = new Student("Hans Grubelar" , 452852);
            Console.WriteLine("New student :");
            Console.WriteLine(studentTest.ToString()); Line('-', 50);
            Class programmingClass = new Class("Artificial Neuron Networks", teachers, students);
            Console.WriteLine("New class with textIdentification : ");
            Console.WriteLine(programmingClass.ToString()); Line('-', 50);
            Discipline neuronNetworksDisc = new Discipline("Artificial Neuron Networks", 5, 1); // test instance of displine
            Discipline machineLearningDisc = new Discipline("Machine Learning", 4, 2, "Advanced displine");// test instance of displine with comment
            Console.WriteLine(neuronNetworksDisc.ToString());
            Console.Write(machineLearningDisc.ToString());
            Console.WriteLine("Added comments      : {0}",machineLearningDisc.Comment); Line('-', 50);


            biologyTeacher.AddDiscipline(neuronNetworksDisc);
            //foreach (var item in biologyTeacher.SetDisciplines)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            biologyTeacher.RemoveDiscipline(2);
            Line('-', 50);
            foreach (var item in biologyTeacher.SetDisciplines)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void Line(char symbol,int lenght)
        {
            Console.WriteLine(new string(symbol, lenght));
        }
        public static string Print(List<Teacher> teachers)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var teacher in teachers)
            {
                sb.AppendLine(teacher.Name);
            }
            return sb.ToString();
        }
            
    }
}
