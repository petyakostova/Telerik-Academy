namespace Students
{
    using System;
    using System.Collections.Generic;

    public abstract class Person : IPerson
    {
        // encapculation
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Name cannot be less than two symbols");
                }

                this.name = value;
            }
        }

        // abstract list, because every student will implement own list with courses:
        //protected abstract List<string> Courses { get; }    // we want to hide it => protected
        protected abstract IEnumerable<string> Courses { get; } // higher abstraction - can be list, hashset, dictionary...

        public string GetAllCourses()   // list all courses without saying which
        {
            return string.Join(" ", this.Courses);
        }
    }
}