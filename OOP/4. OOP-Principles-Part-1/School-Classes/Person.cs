namespace School_Classes
{
    using System;

    public abstract class Person : ICommentable
    {
        private string name;
        private string comment; // optional

        public Person(string name)
        {
            this.Name = name;
        }

        //public Person(string name, string comment)
        //    : this(name)
        //{
        //    this.Comment = comment;
        //}

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
                    if (!Char.IsLetter(letter) && letter != ' ' && letter != '-')
                    {
                        throw new ArgumentException("Invalid name.");
                    }
                }

                this.name = value;
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

    }
}