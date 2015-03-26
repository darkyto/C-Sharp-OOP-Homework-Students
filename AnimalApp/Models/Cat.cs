namespace AnimalApp.Models
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age, Gender gender)
            : base(name, age, gender)
        {

        }
        public override string AnimalSays()
        {
            if (this.Gender.Equals(Gender.Male))
            {
                return string.Format(this.Name + " makes a sound : Meowwww");
            }
            else
            {
                return string.Format(this.Name + " makes a sound : MIau-miau-miau");
            }
        }
        public override string ToString()
        {
            return string.Format("Name: " + this.Name + "\nAge: " + this.Age + "\nGender: " + this.Gender);
        }
    }
}
