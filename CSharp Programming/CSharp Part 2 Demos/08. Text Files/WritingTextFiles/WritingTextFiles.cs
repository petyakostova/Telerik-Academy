using System;
using System.IO;

class WritingTextFiles
{
    static void Main()
    {
        string fileName = "numbers.txt";
        StreamWriter streamWriter = new StreamWriter(fileName);
        using (streamWriter)
        {
            for (int number = 1; number <= 20; number++)
            {
                streamWriter.WriteLine(number);
            }
        }
        Console.WriteLine("File is written!");
    }
}
