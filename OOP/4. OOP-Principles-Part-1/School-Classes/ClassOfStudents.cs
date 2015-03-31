namespace School_Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClassOfStudents : ICommentable
    {
        private List<Teacher> allTeachers;  // set of teachers
        private string textIdentifier;
        private string comment; // optional

        public ClassOfStudents(IEnumerable<Teacher> teachers, string textId) // IEnumerable => using System.Collections.Generic;
        {
            this.allTeachers = teachers.ToList(); // ToList() => using System.Linq;
        }

        public ClassOfStudents(IEnumerable<Teacher> teachers, string textId, string comment) // IEnumerable => using System.Collections.Generic;
            : this(teachers, textId)
        {
            this.Comment = comment;
        }

        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            set
            {
                this.textIdentifier = value;
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

        public List<Teacher> Teachers
        {
            get
            {
                // don't want someone to clear the marks so instead of 
                // return this.allTeachers; =>
                return new List<Teacher>(this.allTeachers);
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.allTeachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (!this.allTeachers.Contains(teacher))
            {
                throw new ArgumentException("No such teacher in the set.");
            }
            this.allTeachers.Remove(teacher);
        }

        public override string ToString()
        {
            return String.Format("Set of teachers: {0}, Text identifier: {1}, Comment: {2}",
                this.Teachers, this.TextIdentifier, this.Comment);
        }

    }
}