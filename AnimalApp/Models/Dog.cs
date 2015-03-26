namespace AnimalApp.Models
{
    using System;

    public class Dog : Animal
    {

        public Dog(string name, int age, Gender gender)
            : base(name, age, gender)
        {

        }

        #region Methods
        public override string AnimalSays()
        {
            if (this.Gender.Equals(Gender.Male))
            {
                return string.Format(this.Name +" makes a sound : Bau-Bauuuuu");
            }
            else
            {
                return string.Format(this.Name + " makes a sound : mmmmBaau");
            }
        }
        public override string ToString()
        {
            return string.Format("Name: "+ this.Name + "\nAge: " + this.Age + "\nGender: " + this.Gender );
        }
        #endregion
    }
}
