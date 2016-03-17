/*  Problem 9. Delete odd lines
    Write a program that deletes from given text file all odd lines.
    The result should be in the same file.
 */

using System;
using System.IO;
using System.Text;

public class DeleteOddLines
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string[] lines = File.ReadAllLines("../../TextFileOriginal.txt",
            Encoding.GetEncoding("windows-1251"));

        for (int index = 0; index < lines.Length; index++)
        {
            Console.WriteLine(lines[index]);
        }

        using (StreamWriter streamWriter = new StreamWriter("../../TextFileResult.txt",
            false, Encoding.GetEncoding("windows-1251")))
        {

            for (int index = 0; index < lines.Length; index++)
            {
                if (index % 2 == 0)
                {
                    streamWriter.WriteLine(lines[index]);
                }
            }

            Console.WriteLine("TextFileResult.txt - Done");
        }
    }
}