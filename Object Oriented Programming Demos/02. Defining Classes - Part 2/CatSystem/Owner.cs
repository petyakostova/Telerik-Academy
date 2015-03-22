// Revision of Defining Classes Part 1

namespace CatSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Owner
    {
        // owner has first and last name, that can't be changed
        // fields
        private string firstName;
        private string lastName;

        // when we use referent types (collections), we must instance them in the constructor otherwise CatSystemStart.cs Line 30
        private List<Cat> cats;

        // constructor for owner with two names
        public Owner(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Age = 0;
            // instance the list in the constructor 
            this.cats = new List<Cat>();
        }

        // possibility for getting the names, but couldn't set them
        // properties
        public string FirstName
        {
            get
            {
                return this.firstName; 
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.firstName, this.lastName);
            }
        }

        public string AllCats
        {
            get
            {
                return string.Join(", ", this.cats.Select(c => c.Name));    // Select => using System.Linq;
            }
        }

        // automatic property - can return value (be appropriated), but can not set (be changed)
        public int Age { get; private set; }

        // methods
        public void IncreaseAge()
        {
            this.Age++;
        }

        public void AddCat(Cat cat, string name)
        {
            if (this.cats.Contains(cat))
            {
                throw new ArgumentException("This owner already owns this cat: " + cat.Name);    // using System
            }

            cat.Name = name;
            cat.Owner = this;   // this => the current owner
            this.cats.Add(cat);
        }
    
    }
}
