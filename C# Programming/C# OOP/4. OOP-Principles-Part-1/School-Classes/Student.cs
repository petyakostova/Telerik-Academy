namespace School_Classes
{
    using System;

    public class Student : Person, ICommentable
    {
        private int classNumber; 
        private string comment; // optional

        public Student(string name, int classNumber) 
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string name, int classNumber, string comment)
            : this(name, classNumber)
        {
            this.Comment = comment;
        }

        public int ClassNumber
        {
            get 
            { 
                return this.classNumber; 
            }
            set 
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Class number cannot be less than 1.");
                }
                this.classNumber = value; 
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

        public override string ToString()
        {
            return string.Format("Student Name: {0}; Class Number: {1}; Comment: {2}", this.Name, this.ClassNumber, this.Comment);
        }
        
    }
}