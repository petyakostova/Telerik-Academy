namespace Students
{
    public interface IPerson
    {
        string Name { get; set; }     // property   
        string GetAllCourses();       // method
        // without: 
        //IEnumerable<string> Courses { get; set; }   // using System.Collections.Generic;
        // because it's not public
    }
}
