/*  Problem 4. Compare text files
    Write a program that compares two text files line by line and 
    prints the number of lines that are the same and the number of lines that are different.
    Assume the files have equal number of lines.
 */

using System;
using System.IO;
using System.Text;

public class CompareTextFiles
{
    public static void Main()
    {
        string[] linesOne = File.ReadAllLines("../../TextFileOne.txt");
        string[] linesTwo = File.ReadAllLines("../../TextFileTwo.txt");

        int maxLength = Math.Max(linesOne.Length, linesTwo.Length);
        int minLength = Math.Min(linesOne.Length, linesTwo.Length);

        for (int line = 0; line < maxLength; line++)
        {
            if (line < minLength)
            {
                if (linesOne[line].Equals(linesTwo[line]))
                {
                    Console.WriteLine("At line {0} : lines from both the file are same.", line);
                }
                else
                {
                    Console.WriteLine("At line {0} : lines are not same.", line);
                }
            }
            else
            {
                Console.WriteLine("Line {0} : doesnt exits in {1} file.", line,
                                                linesOne.Length == minLength ? "first" : "second");
            }
        }
    }
}