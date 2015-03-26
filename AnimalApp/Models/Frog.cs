namespace AnimalApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Frog : Animal
    {
        public Frog(string name, int age, Gender gender)
            : base(name, age, gender)
        {

        }

        #region Methods
        public override string AnimalSays()
        {
            if (this.Gender.Equals(Gender.Male))
            {
                return string.Format(this.Name + " makes a sound : Quake-Quake");
            }
            else
            {
                return string.Format(this.Name + " makes a sound : Qwaaak-Qwak");
            }
        }
        public override string ToString()
        {
            return string.Format("Name: " + this.Name + "\nAge: " + this.Age + "\nGender: " + this.Gender);
        }
        #endregion
    }
}
