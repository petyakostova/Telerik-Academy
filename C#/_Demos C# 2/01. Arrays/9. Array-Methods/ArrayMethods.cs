using System;

class ArrayMethods
{
    static void Main()
    {
        int[] arr = { 3, 2, 5, 4, 1 };
        
        foreach (var item in arr) // elements can not be modified (read only)
        {
            Console.Write(item + " "); // 3 2 5 4 1
        }

        Console.WriteLine("the index of the element with value 5:");
        Console.WriteLine(Array.IndexOf(arr, 5)); // finding the index of the element with value 5 in arr

        Console.WriteLine("Sorted");
        Array.Sort(arr);
        foreach (var item in arr) // elements can not be modified (read only)
        {
            Console.Write(item + " "); // 1 2 3 4 5
        }

        Console.WriteLine(Environment.NewLine + "Reversed");
        Array.Reverse(arr);
        foreach (var item in arr) // elements can not be modified (read only)
        {
            Console.Write(item + " "); // 5 4 3 2 1
        }
        Console.WriteLine();

        // public static void Clear(Array array, int index, int length);
        // Sets a range of elements in an array to the default value of each element type.
        //Array.Clear(arr, 0, arr.Length); // 0 0 0 0 0
        Array.Clear(arr, 1, 2); // 5 0 0 2 1
        foreach (var item in arr) // elements can not be modified (read only)
        {
            Console.Write(item + " ");
        }

    }
}