namespace Students
{
    using System;

    class StudentsMain
    {
        static void Main()
        {
            JuniorStudent jns = new JuniorStudent();
            jns.Name = "Ivan";
            Console.WriteLine(jns.GetAllCourses());
        }
    }
}