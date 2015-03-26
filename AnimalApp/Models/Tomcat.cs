namespace AnimalApp.Models
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Gender.Male)
        {

        }
    }
}
