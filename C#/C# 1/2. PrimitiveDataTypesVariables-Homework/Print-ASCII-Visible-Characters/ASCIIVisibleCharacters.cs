/*Problem 14.* Print the ASCII Table
 Find online more information about ASCII (American Standard Code for Information Interchange) 
 and write a program that prints the visible characters of the ASCII table on the console 
 (characters from 33 to 126 including).
Note: You may need to use for-loops (learn in Internet how).
Input => None
Output => The 94 characters on single line */

using System;
using System.Text;

class ASCIIVisibleCharacters
{
    static void Main()
    {
        //Console.BufferHeight = 95;
        Console.OutputEncoding = Encoding.Unicode;

        for (int i = 33; i < 127; i++)
        {
            //Console.WriteLine("{0} => {1}", i, (char)i);    // Convert.ToChar(i);
            Console.Write("{0}", Convert.ToChar(i));   
        }
    }
}