namespace School_Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Teacher : Person, ICommentable
    {
        private List<Discipline> allDisciplines;

        public Teacher(string name, IEnumerable<Discipline> disciplines) 
            : base(name)
        {
            this.allDisciplines = disciplines.ToList(); // ToList() => using System.Linq;
        }

        public List<Discipline> Disciplines
        {
            get
            {
                // don't want someone to clear the marks so instead of 
                // return this.disciplines; =>
                return new List<Discipline>(this.allDisciplines);
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.allDisciplines.Add(discipline);
        }

        public override string ToString()
        {
            return this.Name + string.Join(", ", this.Disciplines);
        }


    }
}
