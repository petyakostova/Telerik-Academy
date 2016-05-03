using System;
using System.Collections.Generic;

public class ResizingLists
{
    static void Main()
    {
        List<int> list = new List<int>();
        int n = int.Parse(Console.ReadLine());  // how much numbers we add to the array

        string lineBreak = new string('-', 20);

        for (int i = 0; i < n + 1; i++)
        {
            var capacity = list.Capacity;
            var count = list.Count;
            Console.WriteLine("Capacity: {0} Count:{1}",
                capacity, count, lineBreak);
            list.Add(i);
        }

    }
}