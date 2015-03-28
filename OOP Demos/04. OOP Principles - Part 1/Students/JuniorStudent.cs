namespace Students
{
    using System.Collections.Generic;

    public class JuniorStudent : Person
    {
        protected override IEnumerable<string> Courses
        {
            get
            {
                return new HashSet<string> { "Fundamentals of C#", "C# Part 2" }; 
            }
        }
    }
}
