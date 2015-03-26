namespace SchoolApp
{
    using System;
    using System.Collections.Generic;

    public class Student : Person, ICommentable
    {
        //Students have name and unique class number

        private int classNumber = 100000;

        #region Constructor
        public Student(string name , int classNum)
            : base(name)
        {
            this.ClassNumber = classNum;
        }
        #endregion

        #region properties
        public int ClassNumber
        {
            get { return this.classNumber; }
            private set 
            {
                if (classNumber <= 99999)
                {
                    throw new ArgumentException("Unique class number must be at elast six digits long!");
                }
                this.classNumber = value; 
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("Student: " + this.Name + " \nClass NUmber: " + this.ClassNumber);
        }
        #endregion
    }
}
