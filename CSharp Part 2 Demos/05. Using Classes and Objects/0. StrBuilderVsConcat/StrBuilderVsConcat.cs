using System;
using System.Text;

class StrBuilderVsConcat
{
    static void Main()
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < 1000000; i++)
        {
            result.Append("a");
        }

        Console.WriteLine(result);

        // concatenation

        string text = "";
        for (int i = 0; i < 1000000; i++)
        {
            text += "a";
        }

        Console.WriteLine(text);
    }
}