namespace Students
{
    using System;
    using System.Collections.Generic;

    public class StudentsMain
    {
        public static void Main()
        {
            JuniorStudent jns = new JuniorStudent();

            //jns.Name = null;    // this will cause System.ArgumentException: Name cannot be empty
            try
            {
                jns.Name = null;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You entered empty or null name");
            }

            //jns.Name = "Ivan";
            Console.WriteLine(jns.GetAllCourses());

            // this is not the right way to add marks (by fictive list):
            //jns.Marks.Add(50);
            //jns.Marks.Add(100); 

            // the right interface for adding is:
            jns.AddMark(50);
            jns.AddMark(100);

            Console.WriteLine(jns);

            jns.Marks.Clear();  // we don't want someone to clear the marks, so we encapsulate the data in class JuniorStudent

            Console.WriteLine(jns);

            IEnumerable<string> enumerable = new List<string>();      //using System.Collections.Generic;
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