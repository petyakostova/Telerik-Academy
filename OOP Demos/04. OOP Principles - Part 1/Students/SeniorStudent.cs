namespace Students
{
    using System.Collections.Generic;

    class SeniorStudent : Person
    {
        protected override IEnumerable<string> Courses
        {
            get
            {
                return new List<string> { "ASP.NET", "OOP" };
            }
        }
    }
}
