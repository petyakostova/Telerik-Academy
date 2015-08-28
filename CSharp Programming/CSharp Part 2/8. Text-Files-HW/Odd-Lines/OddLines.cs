/*  Problem 1. Odd lines
    Write a program that reads a text file and prints on the console its odd lines.
 */

using System;
using System.IO;
using System.Text;

public class OddLines
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        StreamReader reader = new StreamReader("../../TextFile.txt");

        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();

            while (line != null)
            {
                lineNumber++;

                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                }

                line = reader.ReadLine();
            }
        }
    }
}