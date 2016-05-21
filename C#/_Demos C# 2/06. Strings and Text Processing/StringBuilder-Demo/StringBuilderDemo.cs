using System;
using System.Text; // needed for StringBuilder()

class StringBuilderDemo
{
    public static string ReverseIt(string str)
    {
        StringBuilder sb = new StringBuilder();
        // var sb = new StringBuilder(str.Length);

        for (int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }

        return sb.ToString();
    }

    public static string ExtractCapitals(string str)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];

            if (Char.IsUpper(ch))
            //if (s[i] >= 'A' && s[i] <= 'Z')
            {
                result.Append(ch);
            }
        }

        return result.ToString();
    }

    public static string DupChar(char ch, int count)
    {
        StringBuilder result = new StringBuilder(count);

        for (int i = 0; i < count; i++)
        {
            result.Append(ch);
        }

        return result.ToString();
    }

    static void Main()
    {
        string str = "Telerik Academy";

        string reversed = ReverseIt(str);
        Console.WriteLine(reversed);    //ymedacA kireleT

        string capitals = ExtractCapitals(str);
        Console.WriteLine(capitals);    //TA

        DateTime startTime = DateTime.Now;
		Console.WriteLine("Concatenation 200 000 chars...");
		DupChar('a', 200000);
		DateTime endTime = DateTime.Now;
		Console.WriteLine("... done in {0} seconds", endTime - startTime); // fast
	}

}