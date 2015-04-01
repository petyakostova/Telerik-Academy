namespace School_Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ClassOfStudents : ICommentable
    {
        private List<Teacher> listOfTeachers;  // set of teachers
        private string textIdentifier;
        private string comment; // optional
        private List<Student> listOfStudents;

        public ClassOfStudents(string textId)
        {
            this.TextIdentifier = textId;
            this.listOfTeachers = new List<Teacher>();
            this.listOfStudents = new List<Student>(); 
        }

        public ClassOfStudents(string textId, string comment)
            : this(textId)
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Text Identifier cannot be null or empty");
                }

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

        public List<Teacher> ListOfTeachers
        {
            get
            {
                // don't want someone to clear the marks so instead of 
                // return this.listOfTeachers; =>
                return new List<Teacher>(this.listOfTeachers);
            }
        }

        public List<Student> ListOfStudents
        {
            get
            {
                return new List<Student>(this.listOfStudents);
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.listOfTeachers.Add(teacher);
        }

        public void AddTeacher(params Teacher[] teachers)
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                this.listOfTeachers.Add(teachers[i]);
            }
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (!this.listOfTeachers.Contains(teacher))
            {
                throw new ArgumentException("No such teacher in the set.");
            }
            this.listOfTeachers.Remove(teacher);
        }

        public void AddStudent(Student student)
        {
            this.listOfStudents.Add(student);
        }

        public void AddStudent(params Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                this.listOfStudents.Add(students[i]);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Text identifier: {0}; Comment: {1}", this.TextIdentifier, this.Comment));

            foreach (Teacher teacher in this.ListOfTeachers)
            {
                result.Append(" *" + teacher.ToString());
            }

            foreach (Student st in this.ListOfStudents)
            {
                result.AppendLine("          " + st.ToString());
            }

            return result.ToString();
        }

    }
}