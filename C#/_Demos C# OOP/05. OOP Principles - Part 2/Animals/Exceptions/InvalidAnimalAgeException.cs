namespace Animals.Exceptions
{
    using System;

    public class InvalidAnimalAgeException : ApplicationException
    {
        public InvalidAnimalAgeException(string message, int minAge, int maxAge)
            : base(message) // invokes the base constructor - every exception can accept message
        {
            this.MinAge = minAge;
            this.MaxAge = maxAge;
        }

        public int MinAge { get; private set; }

        public int MaxAge { get; private set; }
    }
}