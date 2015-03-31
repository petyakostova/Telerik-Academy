namespace School_Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private List<ClassOfStudents> allClasses;   // classes of students

        public School(IEnumerable<ClassOfStudents> classes) // IEnumerable => using System.Collections.Generic;
        {
            this.allClasses = classes.ToList(); // ToList() => using System.Linq;
        }

        public List<ClassOfStudents> Classes
        {
            get
            {
                // don't want someone to clear the classes so instead of 
                // return this.allClasses; =>
                return new List<ClassOfStudents>(this.allClasses);
            }
        }

        public void AddClass(ClassOfStudents classStudents)
        {
            this.allClasses.Add(classStudents);
        }

        public void RemoveClass(ClassOfStudents classStudents)
        {
            if (!this.allClasses.Contains(classStudents))
            {
                throw new ArgumentException("No such class of students in school.");
            }
            this.allClasses.Remove(classStudents);
        }

        public override string ToString()
        {
            return string.Join(", ", this.Classes);
        }

    }
}
