namespace Students
{
    using System.Collections.Generic;

    public abstract class Person : IPerson
    {
        public string Name { get; set; }

        // abstract list, because every student will implement own list with courses:
        //protected abstract List<string> Courses { get; }    // pretected => we want to hide it
        protected abstract IEnumerable<string> Courses { get; } // higher abstraction - can be list, hashset, dictionary...
    
        public string GetAllCourses()   // list all courses without saying which
        {
            return string.Join(" ", this.Courses);
        }
    }
}