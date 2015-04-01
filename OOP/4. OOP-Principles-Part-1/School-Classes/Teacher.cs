namespace School_Classes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Person, ICommentable
    {
        private List<Discipline> allDisciplines;    // set of disciplines
        private string comment; // optional

        public Teacher(string name)
            : base(name)
        {
            this.allDisciplines = new List<Discipline>();
        }

        public Teacher(string name, string comment)
            : base(name)
        {
            this.Comment = comment;
            this.allDisciplines = new List<Discipline>();
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

        public string Comment
        {
            get
            {
                // if (this.comment == null)
                if (String.IsNullOrWhiteSpace(this.comment))
                {
                    return "No comment yet.";
                }

                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.allDisciplines.Add(discipline);
        }

        public void AddDiscipline(params Discipline[] disciplines)
        {
            for (int i = 0; i < disciplines.Length; i++)
            {
                this.allDisciplines.Add(disciplines[i]);
            }
        }

        //public void RemoveDiscipline(Discipline discipline)
        //{
        //    if (!this.allDisciplines.Contains(discipline))
        //    {
        //        throw new ArgumentException("No such discipline in the set.");
        //    }
        //    this.allDisciplines.Remove(discipline);
        //}

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Teacher: {0}; Comment: {1}", this.Name, this.Comment));

            foreach (Discipline discipline in allDisciplines)
            {
                result.Append("    -> " + discipline.ToString());
            }
                        
            return result.ToString();
        }

    }
}
