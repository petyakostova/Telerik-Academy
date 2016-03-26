/*Problem 14.* Print the ASCII Table
 * Write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
 * Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.*/

using System;

class PrintTheASCIITable
{
    static void Main()
    {
        Console.BufferHeight = 258;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        
        for (int i = 0; i < 256; i++)
        {
            Console.WriteLine("{0} => {1}", i, (char)i);    // Convert.ToChar(i);
        }
    }
}