using System;

class WithAffect
{
    static void Main()
    {
        /* If we do it the intuitive way we would copy not only the values but the reference to the array.
         * Changing some of the values in one array will affect the other. */

        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;

        Console.WriteLine(arr1[1]);
        Console.WriteLine(arr2[1]);

        Console.WriteLine(new string('-', 10));

        arr2[1] = 123;
        Console.WriteLine(arr1[1]);
        Console.WriteLine(arr2[1]);

    }
}