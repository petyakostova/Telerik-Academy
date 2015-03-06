/*  Problem 6. String length
    Write a program that reads from the console a string of maximum 20 characters. 
    If the length of the string is less than 20, the rest of the characters should be filled with *.
    Print the result string into the console.
 */

using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        Console.WriteLine("Enter a string of maximum 20 characters:");
        string str = Console.ReadLine();
        while (str.Length > 20)
        {
            Console.WriteLine("Incorrect string!");
            Console.WriteLine("Enter a string of maximum 20 characters:");
            str = Console.ReadLine();
        }

        // first way
        str = str.PadRight(20, '*');
        Console.WriteLine(str);  /* Returns a new string that left-aligns the characters in this string
                                                    * by padding them on the right with a specified Unicode character, 
                                                    * for a specified total length. */

        // second way

        //StringBuilder sb = new StringBuilder();

        //for (int i = 0; i < str.Length; i++)    // copy the str in sb
        //{
        //    sb.Append(str[i]);
        //}

        ////int counter = 0;                      // other way for copy the str in sb
        ////while (counter < str.Length)
        ////{
        ////    sb.Append(str[counter]);
        ////    counter++;
        ////}

        //if (sb.Length < 20)
        //{
        //    sb.Append(new string('*', 20 - sb.Length));
        //}
        //Console.WriteLine(sb.ToString());

    }
}