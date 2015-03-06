/*  Problem 11. Prefix "test"
    Write a program that deletes from a text file all words that start with the prefix test.
    Words contain only the symbols 0...9, a...z, A...Z, _.
 */

using System;
using System.IO;
using System.Collections.Generic;

class DeleteAllWordsStartingWithTest
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Text.txt");
        List<string> answer = new List<string>();

        string currLine = reader.ReadLine();

        while (currLine != null)
        {
            int index = currLine.IndexOf("Test");
            if (index != -1)
            {
                if ((currLine[index + 4] != ' ') && (currLine[index + 4] != '.') && (currLine[index + 4] != ',') && (currLine[index + 4] != '-'))
                {
                    currLine = currLine.Substring(0, index) + currLine.Substring(index + 4);
                }
            }
            index = -1;
            index = currLine.IndexOf("test");
            if (index != -1)
            {
                if ((currLine[index + 4] != ' ') && (currLine[index + 4] != '.') && (currLine[index + 4] != ',') && (currLine[index + 4] != '-'))
                {
                    currLine = currLine.Substring(0, index) + currLine.Substring(index + 4);
                }
            }
            answer.Add(currLine);
            currLine = reader.ReadLine();
        }

        reader.Close();

        StreamWriter writer = new StreamWriter(@"..\..\Text.txt", false);

        foreach (string item in answer)
        {
            writer.WriteLine(item);
        }

        writer.Close();

        Console.WriteLine("All words that start with the prefix test deleted!");
    }
}
