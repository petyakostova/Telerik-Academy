/*  4. Sub-string in text
    Write a program that finds how many times a sub-string is contained in a given text 
    (perform case insensitive search).
    Input: On the first line you will receive a string - the pattern
           On the second line you will receive a string - the text
    Output: Print a number on a single line. The number of occurrences
    Constraints: The length of the two strings will be <= 4096
    Sample tests:
                    Input 	                                                                Output
                    in
                    We are living in an yellow submarine. We don't have anything else. 
                    inside the submarine is very tight. So we are drinking all the day. 
                    We will move out of it in 5 days. 	                                    9
 */

using System;

class SubstringInText
{
    static void Main()
    {
        string targetSubstr = Console.ReadLine();
        string str = Console.ReadLine();

        // to perform insensitive search
        targetSubstr = targetSubstr.ToLower();
        str = str.ToLower();

        int counter = 0;
        int index = 0;

        while (true)
        {
            // searching for the targerSubStr in str starting from index, return index or -1 if no found
            int found = str.IndexOf(targetSubstr, index);
            if (found < 0)  // (found == -1)
            {
                break;
            }
            counter++;
            index = found + 1;
        }

        Console.WriteLine(counter);

        // other way

        //int counter = 0;
        //// searching for the targerSubStr in str, return index or -1 if no found
        //int indexer = str.IndexOf(targetSubstr);

        //while (indexer != -1)
        //{
        //    counter++;
        //    indexer = str.IndexOf(targetSubstr, indexer + 1);
        //}

        //Console.WriteLine(counter);
    }
}