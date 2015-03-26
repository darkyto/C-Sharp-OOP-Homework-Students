namespace SchoolApp
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person, ICommentable
    {
        private List<Discipline> setDisciplines;

        public Teacher(string name , List<Discipline> disciplines)
            :base(name)
        {
            this.SetDisciplines = disciplines;
        }

        public List<Discipline> SetDisciplines
        {
            get { return this.setDisciplines; }
            private set 
            {
                if (value.Count <= 0 || value == null)
                {
                    throw new ArgumentException("Can not have and empty list of Disciplines");
                }
                this.setDisciplines = value; 
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.setDisciplines.Add(discipline);
        }
        public void RemoveDiscipline(int index)
        {
            this.setDisciplines.Remove(this.SetDisciplines[index]);
        }

    }
}
