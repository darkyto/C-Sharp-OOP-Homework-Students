namespace SchoolApp
{
    using System;
    using System.Collections.Generic;

    public abstract class Person : ICommentable
    {
        // Both teachers and students are people. 
        private string name;
        private string comment;

        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, string comment)
            :this(name)
        {
            this.Comment = comment;
        }

        public string Comment
        {
            get { return this.comment; }
            private set { this.comment = value; }
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
    }
}
