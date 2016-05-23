/*  15. Replace tags
    Write a program that replaces in a HTML document given as string all the tags 
    <a href="…">…</a> with corresponding tags [URL=…](…/URL).
    Input: On the only input line you will receive a string
    Output: Print the string with replaced tags
    Example:
    Input: 	                                                                
    <p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
    Output:
    <p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */

using System;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        // first way
        //string hTMLDoc = Console.ReadLine();

        //StringBuilder tagReplaced = new StringBuilder();

        //string[] messages = hTMLDoc
        //    .Split(new string[] { "<a href", "</a>" }, StringSplitOptions.None);
        //// The return value includes array elements that contain an empty string

        //foreach (var item in messages)
        //{
        //    int indexOfLink = item.IndexOf("=\"");

        //    if (indexOfLink >= 0)
        //    {
        //        int endIndex = item.IndexOf("\">");
        //        tagReplaced.Append("[URL=");
        //        tagReplaced.Append(item.Substring(indexOfLink + 2, endIndex - indexOfLink - 2));
        //        tagReplaced.Append("]");
        //        tagReplaced.Append(item.Substring(endIndex + 2, item.Length - endIndex - 2));
        //        tagReplaced.Append("[/URL]");
        //    }
        //    else
        //    {
        //        tagReplaced.Append(item);
        //    }
        //}

        //if (tagReplaced.Length == 0)
        //{
        //    Console.WriteLine(hTMLDoc);
        //}
        //else
        //{
        //    Console.WriteLine(tagReplaced.ToString());
        //}

        //other way
        //string hTML = Console.ReadLine();
        //Console.WriteLine(Regex.Replace(hTML, @"<a href=""(.*?)"">(.*?)</a>", @"[URL=$1]$2[/URL]")); 
        //// Uses more Memory

    }
}