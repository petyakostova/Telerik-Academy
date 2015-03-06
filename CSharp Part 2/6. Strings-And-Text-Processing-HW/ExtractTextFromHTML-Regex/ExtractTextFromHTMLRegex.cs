/*  Problem 25. Extract text from HTML => Regex
    Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
    Example input:
        <html>
          <head><title>News</title></head>
          <body><p><a href="http://academy.telerik.com">Telerik
            Academy</a>aims to provide free real-world practical
            training for young people who want to turn into
            skillful .NET software engineers.</p></body>
        </html>
    Output:
        Title: News
        Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.
 */

using System;
using System.Text.RegularExpressions;  // needed for Regex

class ExtractTextFromHTMLRegex
{
    static void Main()
    {
        string text = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        MatchCollection tags = Regex.Matches(text, @"((?<=^|>)[^><]+?(?=<|$))");
        int count = 1;
        foreach (Match tag in tags)
        {
            if (count == 1)
            {
                Console.WriteLine("Title: {0}", tag);
                Console.Write("Text: ");
            }
            else
            {
                Console.Write(tag + " ");
            }
            count++;
        }

        Console.WriteLine(Environment.NewLine);

    }
}