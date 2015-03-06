/*  Problem 3. Read file contents
    Write a program that enters file name along with its full file path 
    (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
    Find in MSDN how to use System.IO.File.ReadAllText(…).
    Be sure to catch all possible exceptions and print user-friendly error messages.
 */

using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        Console.Write("Enter the full path of the file you want to read: ");
        string filePath = Console.ReadLine();

        try
        {
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine("The content of the file is: ");
            Console.WriteLine(fileContent);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file '{0}' was not found!", filePath);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No file path is given!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The entered file path is not correct!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The chosen file is not supported!");
        }
    }
}