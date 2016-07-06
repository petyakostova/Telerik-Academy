// Plus Revision of Defining Classes Part 1

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

        /* when we use referent tyзpes (collections), we must instance them in the constructor 
           otherwise CatSystemStart.cs Console.WriteLine(peshoOwner.AllCats); (Line 42) doesn't work */
        private List<Cat> cats;

        // constructor for owner with two names
        public Owner(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Age = 0;
            // instance the list in the constructor, before use it 
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

        public string AllCats // all cats to the owner
        {
            get
            {
                return string.Join(", ", this.cats.Select(c => c.Name)); // Select => using System.Linq;
                // Dzhinks, Silvestar
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
                throw new ArgumentException("This owner already owns this cat: " + cat.Name); // using System
            }

            cat.Name = name;    // the owner gives a name to the cat
            cat.Owner = this;   // this => the current owner; set the owner

            this.cats.Add(cat); // add cat in the list => the owner has a new cat
        }
    
    }
}