namespace Students
{
    public interface IPerson
    {
        string Name { get; set; }        
        string GetAllCourses();
        // without: 
        //IEnumerable<string> Courses { get; set; }   // using System.Collections.Generic;
        // because it's not public
    }
}
