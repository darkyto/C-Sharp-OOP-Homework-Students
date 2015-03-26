namespace AnimalApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using AnimalApp.Interfaces;
    using AnimalApp.Models;

    public class ConsoleTests
    {
        static void Main(string[] args)
        {
            Line('#', 50);
            Console.WriteLine("         Problem 3 : Animal Hierarchy");
            Line('#', 50);
            /* OK ==== Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. ==== OK
             * OK ==== Dogs, frogs and cats are Animals. (dog-ok,, frog-ok, cat-ok)==== OK
             * OK ==== All animals can produce sound (specified by the ISound interface). ==== OK
             * OK ==== Kittens and tomcats are cats. ==== OK
             * OK ==== All animals are described by age, name and sex. (dog-ok, frog-ok, cat-ok)==== OK
             * OK ==== Kittens can be only female and tomcats can be only male. ==== OK
             * OK ==== Each animal produces a specific sound. (dog-ok,, frog-ok, cat-ok)==== OK

             * Create arrays of different kinds of animals and calculate the average age 
             * of each kind of animal using a static method (you may use LINQ).
             */
            Dog myDog = new Dog("Rex", 2, Gender.Male);
            Dog myDogFemale = new Dog("Lora", 3, Gender.Female);
            Console.WriteLine("Test with two new dogs :");
            Console.WriteLine(myDog.ToString());
            Console.WriteLine(myDog.AnimalSays()); Line('-', 50);
            Console.WriteLine(myDogFemale.ToString());
            Console.WriteLine(myDogFemale.AnimalSays()); Line('-', 50);


            Console.WriteLine("Test with new frog");
            Frog myFrog = new Frog("Frogger", 1, Gender.Male);
            Console.WriteLine(myFrog.ToString());
            Console.WriteLine(myFrog.AnimalSays()); Line('-', 50);

            Console.WriteLine("Test with a kitten");
            Kitten myKitten = new Kitten("Kotence", 1);
            Console.WriteLine(myKitten.ToString());
            Console.WriteLine(myKitten.AnimalSays()); Line('-', 50);

            Console.WriteLine("Test with a Tomcat");
            Tomcat myTomcat = new Tomcat("Joro", 6);
            Console.WriteLine(myTomcat.ToString());
            Console.WriteLine(myTomcat.AnimalSays()); Line('-', 50);

            Console.WriteLine("Calculate the average age for all the animals in the array of animals");
            Animal[] animals = new Animal[5];
            animals[0] = myDog;
            animals[1] = myDogFemale;
            animals[2] = myFrog;
            animals[3] = myKitten;
            animals[4] = myTomcat;

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name + " is " + animal.Age);
            }

            var result = animals.Average(x => x.Age);
            Console.WriteLine("Average age of all animals is : {0} years",result);

            var res2 =
            (double)(from an in animals
               select an.Age).Average()
            ;

            Console.WriteLine("T : {0}",res2);

        }
        public static void Line(char symbol, int lenght)
        {
            Console.WriteLine(new string(symbol, lenght));
        }
    }
}
