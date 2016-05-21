/*  5. Parse tags
    You are given a text. Write a program that changes the text in all regions 
    surrounded by the tags <upcase> and </upcase> to upper-case.
    Input: On the only line you will receive a string - the text
    Output: Print the changed string on one line
    Constraints: The tags will not be nested. String length will be <= 10000
    Sample tests:
    Input 	
    We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else. 	
    Output
    We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */

using System;
using System.Text;
//using System.Text.RegularExpressions;

class ParseTags
{
    static void Main()
    {
        string text = Console.ReadLine();

        StringBuilder sb = new StringBuilder();

        int toUpper = -1;   //checks if we have to enter UPPERCASE MODE

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '<')
            {
                i++;
                toUpper = toUpper * (-1); // an opening tag => start UPPER

                while (text[i] != '>')    // disregard all of the tag's content
                {
                    i++;
                }
            }
            else
            {
                if (toUpper == 1)
                {
                    sb.Append(text[i].ToString().ToUpper());
                }
                else
                {
                    sb.Append(text[i]);
                }

            }
        }
        Console.WriteLine(sb.ToString());

        //other way
        //Console.WriteLine(Regex
        //    .Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper()));
    }
}