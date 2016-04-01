using System;
using System.Collections.Generic;

public class ExtensionMethods
{
    public static void Main()
    {
        var str = "Hello Extension Methods";
        Console.WriteLine(str.WordCount());//3

        var ints = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine(ints.ToString());//System.Collections.Generic.List`1[System.Int32]
        Console.WriteLine(ints.ToString<int>());//[ 1 2 3 4 5 ]

        ints.IncreaseWidth(5);
        Console.WriteLine(ints.ToString<int>());//[ 6 7 8 9 10 ]
    }
}
