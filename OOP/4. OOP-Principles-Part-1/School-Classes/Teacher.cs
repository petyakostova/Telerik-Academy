namespace School_Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Teacher : Person, ICommentable
    {
        private List<Discipline> allDisciplines;    // set of disciplines

        public Teacher(string name, IEnumerable<Discipline> disciplines)
            : base(name)
        {
            this.allDisciplines = disciplines.ToList(); // ToList() => using System.Linq;
        }

        public Teacher(string name, IEnumerable<Discipline> disciplines, string comment)
            : this(name, disciplines)
        {
            this.Comment = comment;
        }

        public List<Discipline> Disciplines
        {
            get
            {
                // don't want someone to clear the marks so instead of 
                // return this.allDisciplines; =>
                return new List<Discipline>(this.allDisciplines);
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.allDisciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            if (!this.allDisciplines.Contains(discipline))
            {
                throw new ArgumentException("No such discipline in the set.");
            }
            this.allDisciplines.Remove(discipline);
        }

        public override string ToString()
        {
            return this.Name + string.Join(", ", this.Disciplines);
        }

    }
}
