/*  Problem 6. Save sorted names
    Write a program that reads a text file containing a list of strings, 
    sorts them and saves them to another text file.
    Example:
            input.txt 	    output.txt
            Ivan            George
            Peter           Ivan
            Maria           Maria
            George 	        Peter
 */

using System;
using System.Collections.Generic;
using System.IO;

public class SaveSortedNames
{
    public static void Main()
    {
        SaveSortedList(GetList());
    }

    private static void SaveSortedList(List<String> listOfNames)
    {
        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            for (int index = 0; index < listOfNames.Count; index++)
            {
                writer.WriteLine(listOfNames[index]);
            }

            Console.WriteLine("output.txt - Done");
        }
    }

    private static List<String> GetList()
    {
        using (StreamReader reader = new StreamReader("../../input.txt"))
        {
            List<string> listOfNames = new List<string>();
            int lineNumber = 0;

            string line = reader.ReadLine();
            char[] separators = new char[] { ' ', '|' };

            while (line != null)
            {
                string[] pointCoords = line.Split(separators,
                    StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in pointCoords)
                {
                    listOfNames.Add(item);
                }

                lineNumber++;
                line = reader.ReadLine();
            }

            listOfNames.Sort();

            return listOfNames;
        }
    }
}