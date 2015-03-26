namespace SchoolApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Discipline : ICommentable
    {
        #region
        private string comment;
        private string name;
        private int lectionCount;
        private int exersizeCount;
        #endregion

        #region Constructors
        public Discipline(string name , int lectionsCount , int exersizesCount)
        {
            this.Name = name;
            this.LectionCount = lectionsCount;
            this.ExerrciesCount = exersizesCount;
        }
        public Discipline(string name, int lectionsCount, int exersizesCount , string comment)
            : this(name, lectionsCount, exersizesCount)
        {
            this.Comment = comment;
        }
        #endregion

        #region Properties
        public int ExerrciesCount
        {
            get { return this.exersizeCount; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of workshops can not be negative");
                }
                this.exersizeCount = value; 
            }
        }

        public int LectionCount
        {
            get { return this.lectionCount; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of lections can not be negative or 0");
                }
                this.lectionCount = value; 
            }
        }

        public string Name
        {
            get { return this.name; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name value cannot be null or empty string");
                }
                this.name = value; 
            }
        }

        public string Comment
        {
            get { return this.comment; }
            private set { this.comment = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Discipline          : " + this.Name);
            sb.AppendLine("NUmber of lections  : " + this.LectionCount.ToString());
            sb.AppendLine("NUmber of workshops : " + this.ExerrciesCount.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
