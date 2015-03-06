using System;
using System.Linq;

class UsingClone
{
    static void Main()
    {
        /* This way only the values will be copied but not the reference */

        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = (int[])arr1.Clone();  // методът Clone връща обект (т.е. не знае кой е точният тип) затова конвертираме към масив от int-ове
        Console.WriteLine(arr1[1]);
        Console.WriteLine(arr2[1]);
        Console.WriteLine(new string('-', 10));
        arr2[1] = 123;
        Console.WriteLine(arr1[1]); // стойността се запазва
        Console.WriteLine(arr2[1]);

        Console.WriteLine("Methods with arrays");

        Array.IndexOf(arr1, 2); // в първия масив намираме индекса на елемента със стойност 2
        Array.Clear(arr2, 0, arr2.Length);
        Array.Reverse(arr1);
        Array.Sort(arr1);

        // using System.Linq;
        int[] arr3 = { 6, 1, -22, 39, -6 };
        arr3 = arr3.OrderBy(x => Math.Abs(x))      // сортирай ги по абс.ст-т
            .ToArray(); // резултатът ми го направи на масив
        foreach (var item in arr3)
        {
            Console.Write(item + " ");
        } 
        Console.WriteLine();

        int[] arr4 = { 6, 1, -22, 39, -6 };
        arr4 = arr4.Where(x => x < 0)      // взимаме всички отрицателни елементи
            .ToArray(); // резултатът ми го направи на масив
        foreach (var item in arr4)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();


    }
}