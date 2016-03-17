/*  Problem 7. Replace sub-string
    Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
    Ensure it will work with large files (e.g. 100 MB).
 */

using System;
using System.IO;

public class ReplaceSubString
{
    public static void Main()
    {
        using (StreamReader streamReader = new StreamReader("../../Text.txt"))
        {
            using (StreamWriter streamWriter = new StreamWriter("../../Result.txt"))
            {
                string line = streamReader.ReadLine();

                while (line != null)
                {
                    streamWriter.WriteLine(line.Replace("start", "finish"));
                    line = streamReader.ReadLine();
                }

                Console.WriteLine("Result.txt - Done");
            }
        }
    }
}