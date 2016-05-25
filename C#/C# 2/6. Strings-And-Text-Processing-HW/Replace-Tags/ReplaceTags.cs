/*  15. Replace tags
    Write a program that replaces in a HTML document given as string 
    all the tags <a href="URL">TEXT</a> with corresponding markdown notation [TEXT](URL).
    Input: On the only input line you will receive a string
    Output: Print the string with replaced tags
    Example:
    Input: 	                                                                
    <p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
    Output:
    <p>Please visit [our site](http://academy.telerik.com) to choose a training course. Also visit [our forum](www.devbg.org) to discuss the courses.</p>
 */

using System;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        // first way => 10 runtime errors => 0/100
        string hTMLDoc = Console.ReadLine();

        StringBuilder tagReplaced = new StringBuilder();

        string[] text = hTMLDoc
            .Split(new string[] { "<a href", "</a>" }, StringSplitOptions.None);
        // The return value includes array elements that contain an empty string

        foreach (var word in text)
        {
            int indexOfLink = word.IndexOf("=\"");

            if (indexOfLink >= 0)
            {
                int endIndex = word.IndexOf("\">");
                tagReplaced.Append("[");
                tagReplaced.Append(word.Substring(endIndex + 2, word.Length - endIndex - 2));
                tagReplaced.Append("](");
                tagReplaced.Append(word.Substring(indexOfLink + 2, endIndex - indexOfLink - 2));
                tagReplaced.Append(")");
            }
            else
            {
                tagReplaced.Append(word);
            }
        }

        if (tagReplaced.Length == 0)
        {
            Console.WriteLine(hTMLDoc);
        }
        else
        {
            Console.WriteLine(tagReplaced.ToString());
        }

        //other way => 2 Memory Limits => 0/100
        //string hTML = Console.ReadLine();
        //string pattern = @"<a href=""(.*?)"">(.*?)</a>";
        //string replacement = @"[$2]($1)";
        //Console.WriteLine(Regex.Replace(hTML, pattern, replacement));

    }
}