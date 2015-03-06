/*  Problem 10. Extract text from XML
    Write a program that extracts from given XML file all the text without the tags.
    Example:
        <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
 */

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class ExtractTextFromXML
{
    public static void Main()
    {
        Console.WriteLine("================================================");

        using (StreamReader streamReader = new StreamReader("../../TestXML.xml"))
        {
            for (int index; (index = streamReader.Read()) != -1; )
            {
                if (index == '>')
                {
                    StringBuilder text = new StringBuilder();

                    while (((index = streamReader.Read()) != '<') && index != -1)
                    {
                        text.Append((char)index);
                    }

                    string newText = Convert.ToString(text).Trim();

                    if (!String.IsNullOrWhiteSpace(newText))
                    {
                        Console.WriteLine(newText);
                    }
                }
            }
        }

        Console.WriteLine("================================================");

        string textXML = File.ReadAllText("../../TestXML.xml");
        string pattern = @"(?s)>\s*(.*?)\s*<";
        var str = Regex.Matches(textXML, pattern);

        for (int index = 0; index < str.Count; index++)
        {
            var result = str[index].Groups[1].Value;

            if (!string.IsNullOrWhiteSpace(result))
            {
                Console.WriteLine(result);
            }
        }

        Console.WriteLine("================================================");
    }
}