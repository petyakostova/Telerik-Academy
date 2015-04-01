namespace School_Classes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private List<ClassOfStudents> allClasses;   // classes of students
        private string name;

        public School(string name)
        {
            this.Name = name;
            this.allClasses = new List<ClassOfStudents>();
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

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
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
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("School: {0}{1}", this.Name, Environment.NewLine));            

            foreach (ClassOfStudents currentClass in this.Classes)
            {
                result.AppendLine(currentClass.ToString());
            }

            return result.ToString();
        }

    }
}
