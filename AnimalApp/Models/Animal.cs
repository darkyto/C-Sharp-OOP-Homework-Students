namespace AnimalApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Interfaces;

    public abstract class Animal : ISound 
    {
        #region Fields
        private string name;
        private int age;
        private Gender gender;
        #endregion

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        #region Properties
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        #region Methods
        public abstract string AnimalSays(); // call this abstract method into each different anmial and make them diff sounds

        #endregion
    }
}
