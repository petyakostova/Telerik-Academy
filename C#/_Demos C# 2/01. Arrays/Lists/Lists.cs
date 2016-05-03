using System;
using System.Collections.Generic;

public class Lists
{
    static void Main()
    {
        List<string> listOfStrings = new List<string>();

        string[] arrayOfStrings = { "Pesho", "Ivan", "Dobri", "Gosho" };

        foreach (string str in arrayOfStrings)
        {
            listOfStrings.Add(str);
        }

        Console.WriteLine("Using \"foreach\" loop to traverse the List");
        Console.WriteLine(new string('-', 20));
        foreach (string str in listOfStrings)
        {
            Console.Write(str + " ");
        }

        Console.WriteLine();
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Using \"for\" loop to traverse the List");
        Console.WriteLine(new string('-', 20));

        listOfStrings.Add("Batman");

        for (int i = 0; i < listOfStrings.Count; i++)
        {
            Console.Write(listOfStrings[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine(new string('-', 50));

        // public void Insert(int index, T item);
        // Inserts an element into the System.Collections.Generic.List`1 at the specified index.
        listOfStrings.Insert(1, "Dimiter"); 

        for (int i = 0; i < listOfStrings.Count; i++)
        {
            Console.Write(listOfStrings[i] + " ");
        }

        Console.WriteLine();
    }
}