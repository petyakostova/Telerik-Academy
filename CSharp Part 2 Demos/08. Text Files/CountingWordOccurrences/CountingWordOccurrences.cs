using System;
using System.IO;

class CountingWordOccurrences
{
    static void Main()
    {
        string fileName = @"..\..\somefile.txt";
        StreamReader reader = new StreamReader(fileName);

        string text;
        using (reader)
        { 
            text = reader.ReadToEnd(); 
        }

        int count = 0;
        int index = text.IndexOf("foundme", 0);
        while (index != -1)
        {
            count++;
            index = text.IndexOf("foundme", index + 1);
        }
        Console.WriteLine(count);
    }
}
