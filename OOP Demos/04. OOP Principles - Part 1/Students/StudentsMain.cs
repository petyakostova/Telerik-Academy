namespace Students
{
    using System;
    using System.Collections.Generic;

    class StudentsMain
    {
        static void Main()
        {
            JuniorStudent jns = new JuniorStudent();
            jns.Name = "Ivan";
            Console.WriteLine(jns.GetAllCourses());

            IEnumerable<string> enumerable = new List<string>(); //using System.Collections.Generic;
            IEnumerable<string> hashset = new HashSet<string>();      //using System.Collections.Generic;
            // List and HashSet can be foreach... because there are from same interface

            ISet<string> set = new SortedSet<string>();     
            ISet<string> anotherSet = new HashSet<string>();
            // SortedSet and HashSet implement ISet<T> and have same methods
        }

        //static void Print(ISet<string> set)
        //{
        //    return; 
        //}
    }
}