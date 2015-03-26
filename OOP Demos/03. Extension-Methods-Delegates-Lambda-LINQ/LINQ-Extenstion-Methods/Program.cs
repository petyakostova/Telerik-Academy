using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        LinqKeywordsExamples();
        LinqExtensionMethodsExamples();
    }

    private static void LinqKeywordsExamples()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        var querySmallNums =
            from num in numbers
            where num < 5
            select num;

        foreach (var num in querySmallNums)
        {
            Console.Write(num.ToString() + " ");//4 1 3 2 0
        }
        
        Console.WriteLine();
        Console.WriteLine();

        string[] towns = { "Sofia", "Varna", "Pleven", "Ruse", "Bourgas" };

        var townPairs =
          from t1 in towns
          from t2 in towns
          select new { T1 = t1, T2 = t2 };

        foreach (var townPair in townPairs)
        {
            Console.WriteLine(townPair);
        }
        //{ T1 = Sofia, T2 = Sofia }
        //{ T1 = Sofia, T2 = Varna }
        //{ T1 = Sofia, T2 = Pleven }
        //{ T1 = Sofia, T2 = Ruse }
        //{ T1 = Sofia, T2 = Bourgas }
        //{ T1 = Varna, T2 = Sofia }
        //{ T1 = Varna, T2 = Varna }
        //{ T1 = Varna, T2 = Pleven }
        //{ T1 = Varna, T2 = Ruse }
        //{ T1 = Varna, T2 = Bourgas }
        //{ T1 = Pleven, T2 = Sofia }
        //{ T1 = Pleven, T2 = Varna }
        //{ T1 = Pleven, T2 = Pleven }
        //{ T1 = Pleven, T2 = Ruse }
        //{ T1 = Pleven, T2 = Bourgas }
        //{ T1 = Ruse, T2 = Sofia }
        //{ T1 = Ruse, T2 = Varna }
        //{ T1 = Ruse, T2 = Pleven }
        //{ T1 = Ruse, T2 = Ruse }
        //{ T1 = Ruse, T2 = Bourgas }
        //{ T1 = Bourgas, T2 = Sofia }
        //{ T1 = Bourgas, T2 = Varna }
        //{ T1 = Bourgas, T2 = Pleven }
        //{ T1 = Bourgas, T2 = Ruse }
        //{ T1 = Bourgas, T2 = Bourgas }

        Console.WriteLine();

        string[] fruits = { "cherry", "apple", "blueberry", "banana" };

        // Sort in ascending sort
        var fruitsAscending =
            from fruit in fruits
            orderby fruit
            select fruit;

        foreach (string fruit in fruitsAscending)
        {
            Console.WriteLine(fruit);
        }
        //apple
        //banana
        //blueberry
        //cherry

        Console.WriteLine();
    }

    private static void LinqExtensionMethodsExamples()
    {
        var studentsRepository = new StudentsRepository();
        var students = studentsRepository.GetAllStudents();

        // where
        var someStudents = students.Where(st => st.Name == "Ivan" || st.Name == "Pesho");
        PrintCollection(someStudents);
        //1; Name: Ivan; Courses: 2
        //3; Name: Pesho; Courses: 2

        // first
        Student first = students.FirstOrDefault(st => st.Courses.Count == 4); // First
        Console.WriteLine(first);

        // select
        var projectedItems = students.Select(
            st => new Student { Name = st.Id.ToString(), Courses = new List<Course>() });
        PrintCollection(projectedItems);
        //0; Name: 1; Courses: 0
        //0; Name: 2; Courses: 0
        //0; Name: 3; Courses: 0

        // select to annonymous
        var annStudents = students.Select(st => new { Id = st.Id, Courses = st.Courses.Count });
        PrintCollection(annStudents);
        //{ Id = 1, Courses = 2 }
        //{ Id = 2, Courses = 3 }
        //{ Id = 3, Courses = 2 }

        // order by
        var ordered = students.OrderBy(st => st.Courses.Count).ThenBy(st => st.Name);
        PrintCollection(ordered);
        //1; Name: Ivan; Courses: 2
        //3; Name: Pesho; Courses: 2
        //2; Name: Gosho; Courses: 3

        // any
        bool checkAny = students.Any(st => st.Name.StartsWith("I"));
        Console.WriteLine(checkAny);//True

        // all
        bool checkAll = students.All(st => st.Name != string.Empty);
        Console.WriteLine(checkAll);//True
        checkAll = students.All(st => st.Id > 2);
        Console.WriteLine(checkAll);//False

        // ToList and ToArray
        Student[] arrayOfStudents = students.ToArray();
        PrintCollection(arrayOfStudents);
        //1; Name: Ivan; Courses: 2
        //2; Name: Gosho; Courses: 3
        //3; Name: Pesho; Courses: 2

        List<Student> listOfStudents = arrayOfStudents.ToList();
        PrintCollection(listOfStudents);
        //1; Name: Ivan; Courses: 2
        //2; Name: Gosho; Courses: 3
        //3; Name: Pesho; Courses: 2

        // reading string of numbers separated by space
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();//1 2 3
        PrintCollection(numbers);
        //1
        //2
        //3

        // reverse
        students.Reverse();
        PrintCollection(students);
        //1; Name: Ivan; Courses: 2
        //2; Name: Gosho; Courses: 3
        //3; Name: Pesho; Courses: 2

        // average
        double averageCourses = students.Average(st => st.Courses.Count);
        Console.WriteLine(averageCourses);//2,33333333333333

        // max
        int max = students.Max(st => st.Courses.Count);
        Console.WriteLine(max);//3

        // min
        int min = students.Min(st => st.Courses.Count);
        Console.WriteLine(min);//2

        // count
        int count = students.Count(st => st.Name.Length > 4);
        Console.WriteLine(count);//2

        // sum
        int sum = students.Sum(st => st.Courses.Count);
        Console.WriteLine(sum);//7

        // extension methods
        var someCollection =
            students.Where(st => st.Id > 1)
                .OrderBy(st => st.Name)
                .ThenBy(st => st.Courses.Count)
                .Select(st => new { Name = st.Name, Courses = st.Courses.Count })
                .ToArray();

        PrintCollection(someCollection);
        //{ Name = Gosho, Courses = 3 }
        //{ Name = Pesho, Courses = 2 }

        // nesting
        var someOtherStudents = students.Where(st => st.Courses.Any(c => c.Name == "OOP")).OrderBy(st => st.Name);
        PrintCollection(someOtherStudents);
        //2; Name: Gosho; Courses: 3
        //1; Name: Ivan; Courses: 2
    }

    private static void PrintCollection(IEnumerable collection)
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }
}