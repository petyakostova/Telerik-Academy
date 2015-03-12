namespace Animals
{
    using System;

    public abstract class Animal
    { 
        private string name;   // field for animal's name, which is readonly

        public string Name
        {
            get
            {
                return this.name;
            } 
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Name must be longer than 3 symbols");
                }

                this.name = value;
            }
        }

        public int Health { get; set; }
    }
}
