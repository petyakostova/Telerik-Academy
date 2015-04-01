namespace School_Classes
{
    using System;
    using System.Text;

    public class Discipline : ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment; // optional

        public Discipline(string name, int numOfLectures, int numOfExercises)            
        {
            this.Name = name;
            this.NumberOfLectures = numOfLectures;
            this.NumberOfExercises = numOfExercises;            
        }

        public Discipline(string name, int numOfLectures, int numOfExercises, string comment)
            : this(name, numOfLectures, numOfExercises)
        {
            this.Comment = comment;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))    //if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }

                foreach (var letter in value)
                {
                    if (!Char.IsLetter(letter) && (!Char.IsDigit(letter)) 
                        && letter != ' ' && letter != '-' && letter != '#')
                    {
                        throw new ArgumentException("Invalid name.");
                    }
                }

                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("The number of lecturers cannot be less than 1.");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("The number of exercises cannot be less than 1.");
                }

                this.numberOfExercises = value;
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
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("Discipline Name: {0}; ", this.Name));
            result.Append(string.Format("Number of lectures: {0}; ", this.NumberOfLectures));
            result.Append(string.Format("Number of exercises: {0}; ", this.NumberOfExercises));
            result.AppendLine(string.Format("Comment: {0}", this.Comment));

            return result.ToString();
        }

    }
}