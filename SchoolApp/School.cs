namespace SchoolApp
{
    using System;
    using System.Collections.Generic;

    /*
     * We are given a school. 
     * OK === In the school there are classes of students. === OK
     * OK === Each class has a set of teachers. === OK
     * OK === Each teacher teaches a set of disciplines. === OK
     * OK === Students have name and unique class number.  === OK
     * OK === Classes have unique text identifier.  === OK
     * OK === Teachers have name. === OK
     * OK === Disciplines have name, number of lectures and number of exercises. === OK
     * OK === Both teachers and students are people. === OK
     * OK === Students, classes, teachers and disciplines could have optional comments (free text block). === OK
     * 
     * Your task is to identify the classes (in terms of OOP) and their attributes and operations, 
     * encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
     */

    public class School
    {
        // In the school there are classes of students. 
        // add classes (of students and teachers)
        private string name;
        private List<Class> classes;

        #region Constructors
        public School(string name)
        {
            this.Name = name;
        }
        public School(string name , List<Class> classes)
            :this(name)
        {
            this.Classes = classes;
        }
        #endregion

        #region  Properties
        public string Name
        {
            get { return this.name; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be Null of empty string");
                }
                this.name = value; 
            }
        }
        public List<Class> Classes
        {
            get { return this.classes; }
            private set { this.classes = value; }
        }
        #endregion

    }
}
