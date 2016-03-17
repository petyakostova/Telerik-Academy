using System;
using System.IO;

class ReadingTextFiles
{
    static void Main()
    {
        string fileName = @"..\..\ReadingTextFiles.cs";
        Console.WriteLine("The contents of the file {0} is:", fileName);

        StreamReader streamReader = new StreamReader(fileName);

        using (streamReader)
        {
            string fileContents = streamReader.ReadToEnd();
            Console.WriteLine(fileContents);
        }

        Console.WriteLine("\n\nNow line by line:");

        StreamReader reader = new StreamReader(fileName);
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = reader.ReadLine();
            }
        }
    }
}
