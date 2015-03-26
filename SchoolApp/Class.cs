namespace SchoolApp
{
    using System;
    using System.Collections.Generic;

    public class Class : ICommentable
    {
        #region fields
        private string classID;
        private List<Teacher> teachers;
        private List<Student> students;
        private string comment;
        #endregion

        #region Constuctors
        public Class(string classID)
        {
            this.ClassIDNumber = classID;
        }
        public Class(string classID , List<Teacher> teachers)
            : this(classID)
        {
            this.Teachers = teachers;
        }
        public Class(string classID, List<Teacher> teachers, List<Student> students)
            : this(classID , teachers)
        {
            this.Students = students;
        }
        #endregion

        #region Properties
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
        public List<Teacher> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }
        public string ClassIDNumber
        {
            get { return classID; }
            set { classID = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("Class Topic (text-identificator): " + this.ClassIDNumber.ToUpper());
        }
        #endregion

    }
}
