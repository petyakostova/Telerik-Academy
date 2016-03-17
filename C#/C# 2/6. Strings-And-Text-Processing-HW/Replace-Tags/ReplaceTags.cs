/*  Problem 15. Replace tags
    Write a program that replaces in a HTML document given as string all the tags 
    <a href="…">…</a>   with corresponding tags     [URL=…]…[/URL].
    Example:
    input: 	                                                                
    <p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
    output:
    <p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */

using System;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        string hTMLDoc = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        StringBuilder tagReplaced = new StringBuilder();

        string[] messages = hTMLDoc.Split(new string[] { "<a href", "</a>" }, StringSplitOptions.None); // The return value includes array elements that contain an empty string

        foreach (var item in messages)
        {
            int indexOfLink = item.IndexOf("=\"");

            if (indexOfLink >= 0)
            {
                int endIndex = item.IndexOf("\">");
                tagReplaced.Append("[URL=");
                tagReplaced.Append(item.Substring(indexOfLink + 2, endIndex - indexOfLink - 2));
                tagReplaced.Append("]");
                tagReplaced.Append(item.Substring(endIndex + 2, item.Length - endIndex - 2));
                tagReplaced.Append("[/URL]");
            }
            else
            {
                tagReplaced.Append(item);
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

        //Console.WriteLine();
        //// other way
        //string HTML = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        //Console.WriteLine(Regex.Replace(HTML, @"<a href=""(.*?)"">(.*?)</a>", @"[URL=$1]$2[/URL]"));

    }
}