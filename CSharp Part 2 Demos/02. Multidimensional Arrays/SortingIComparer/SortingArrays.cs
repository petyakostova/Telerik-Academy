using System;
using System.Collections.Generic;

public class SortingArrays
{
    private static void Main()
    {
        int[] numbers = { 1, 2, 5, 10, 11 };

        Array.Sort(numbers, new NumbersComparer()); // създ. нов обект NumbersComparer

        Console.WriteLine("Numbers sorted by modul 5");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();

        Array.Sort(numbers, (x, y) => (y % 6).CompareTo(x % 6));    // изреждаме 2 параметъра, к.отиват в няк.функция

        Console.WriteLine("Numbers sorted descending:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();

        string[] students = { "Doncho Minkov", "Nikolay Kostov", "Ivaylo Kenov", "Evlogi Hristov" };
        Array.Sort(students, new StudentsComparer());   // имаме си отделен клас за сравнение
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }

    // клас, сравняващ числата според това как те се делят на 5 - остатъка им
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
            var lastName1 = student1.Substring(student1.IndexOf(' ') + 1);  // намира първия интервал и взима останалата част от стринга
            var lastName2 = student2.Substring(student2.IndexOf(' ') + 1);
            return lastName1.CompareTo(lastName2);
        }
    }
}
