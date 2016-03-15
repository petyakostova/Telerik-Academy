/*  Problem 4. Sub-string in text
    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
    Example:
    The target sub-string is "in"
    The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
    The result is: 9
 */

using System;

class SubstringInText
{
    static void Main()
    {
        // for easier testing
        string str = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string targetSubstr = "in";
        //// the real input
        //string str = Console.ReadLine();
        //targetSubstr = Console.ReadLine();

        str = str.ToLower();    // to perform insensitive search

        int count = 0;
        int index = 0;
        
        while (true)
        {
            int found = str.IndexOf(targetSubstr, index);   /* searching for the targerSubStr in str starting from index
                                                             * return index or -1 if no found     */
            if (found < 0)  // (found == -1)
            {
                break;
            }
            count++;
            index = found + 1;
        }
        Console.WriteLine(count);

        //// other way

        //int counter = 0;
        //int indexer = str.IndexOf(targetSubstr);    /* searching for the targerSubStr in str 
        //                                             * return index or -1 if no found     */

        //while (indexer != -1)
        //{
        //    counter++;
        //    indexer = str.IndexOf(targetSubstr, indexer + 1);
        //}

        //Console.WriteLine(counter);
    }
}