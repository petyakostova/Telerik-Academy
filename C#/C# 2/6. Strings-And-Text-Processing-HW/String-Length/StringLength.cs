/*  6. String length
    Write a program that reads from the console a string of maximum 20 characters. 
    If the length of the string is less than 20, the rest of the characters should be filled with *.
    Input: On the only line you will receive a string
    Output: Output a string with length 20
    Constraints: The length of the given string will be <= 20
    Sample tests:
    Input 	                    Output
    hello 	                    hello***************
    -=StringOfLength20=- 	    -=StringOfLength20=-
 */

using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        string str = Console.ReadLine().Replace("\\", string.Empty);
        //string str = Console.ReadLine().Replace(@"\", string.Empty);

        // first way
        /* Returns a new string that left-aligns the characters in this string
           by padding them on the right with a specified Unicode character, for a specified total length. */
        str = str.PadRight(20, '*');
        Console.WriteLine(str);

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