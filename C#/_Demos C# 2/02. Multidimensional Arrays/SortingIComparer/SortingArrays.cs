using System;
using System.Collections.Generic;

public class SortingArrays
{
    private static void Main()
    {
        int[] numbers = { 1, 2, 5, 10, 11 };

        Array.Sort(numbers, new NumbersComparer()); // create new object NumbersComparer

        Console.WriteLine("Numbers sorted by modul 5");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();

        Array.Sort(numbers, (x, y) => (y % 6).CompareTo(x % 6));  

        Console.WriteLine("Numbers sorted descending:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();

        string[] students = { "Doncho Minkov", "Nikolay Kostov", "Ivaylo Kenov", "Evlogi Hristov" };
        Array.Sort(students, new StudentsComparer());   // we have individual class for comparison
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }

    // class for comparing the numbers according to how they are divided into 5 - their remainder
    private class NumbersComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return (x % 5).CompareTo(y % 5);
        }
    }

    private class StudentsComparer : IComparer<string>
    {
        public int Compare(string student1, string student2)
        {
            // find the first interval and take the rest part of the string
            var lastName1 = student1.Substring(student1.IndexOf(' ') + 1); 
             
            var lastName2 = student2.Substring(student2.IndexOf(' ') + 1);

            return lastName1.CompareTo(lastName2);
        }
    }

}