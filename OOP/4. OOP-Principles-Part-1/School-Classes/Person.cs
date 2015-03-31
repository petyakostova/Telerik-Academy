namespace School_Classes
{
    using System;

    public abstract class Person : ICommentable
    {
        private string name;
        private string comments;

        public Person(string name)
        {
            this.Name = name;
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
                    if (!Char.IsLetter(letter) && letter != ' ' && letter != '-')
                    {
                        throw new ArgumentException("Invalid name.");
                    }
                }

                this.name = value;
            }
        }

        public string Comments
        {
            get
            {
                // if (this.comments == null)
                if (String.IsNullOrWhiteSpace(this.comments))   
                {
                    return "No comments yet.";
                }

                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }

    }
}