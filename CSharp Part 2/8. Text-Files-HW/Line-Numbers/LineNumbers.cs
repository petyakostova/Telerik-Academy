/*  Problem 3. Line numbers
    Write a program that reads a text file and inserts line numbers in front of each of its lines.
    The result should be written to another text file.
 */

using System;
using System.IO;
using System.Text;

public class LineNumbers
{
    public static void Main()
    {
        Console.BufferHeight = 200;	
        
        Console.OutputEncoding = Encoding.UTF8;

        using (StreamReader reader = new StreamReader("../../OdaZaLewski.txt", Encoding.GetEncoding("windows-1251")))
        {
            int lineNumber = 0;
            string line = reader.ReadLine();

            using (StreamWriter writer = new StreamWriter("../../Result.txt", false, Encoding.GetEncoding("windows-1251")))
            {
                while (line != null)
                {
                    if (!String.IsNullOrWhiteSpace(line))
                    {
                        writer.WriteLine("{0} : {1}", lineNumber, line);
                        lineNumber++;
                    }

                    line = reader.ReadLine();
                }
            }
        }


        using (StreamReader readerResult = new StreamReader("../../Result.txt", Encoding.GetEncoding("windows-1251")))
        {
            int lineNumber = 0;

            string line = readerResult.ReadLine();

            while (line != null)
            {
                lineNumber++;

                Console.WriteLine(line);

                line = readerResult.ReadLine();
            }
        }
    }
}