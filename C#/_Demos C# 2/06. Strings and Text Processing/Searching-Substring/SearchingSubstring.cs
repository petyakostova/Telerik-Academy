using System;

class SearchingSubstring
{
    static void Main()
    {
        string text = "ivo aaac ivo pesho ivan pesho ivo";

        int index = 0;
        while (true)
        {
            int found = text.IndexOf("pesho", index);
            if (found < 0)
            {
                break;
            }
            Console.WriteLine(found);   
            index = found + 1;
            // 13
            // 24
        }

        Console.WriteLine();

        index = 0;
        while (true)
        {
            int found = text.IndexOf("aa", index);
            if (found < 0)
            {
                break;
            }
            Console.WriteLine(found);
            index = found + 1;
            // 4
            // 5
        }

        Console.WriteLine();

        int foundIvo = text.LastIndexOf("ivo");
        Console.WriteLine(foundIvo); // 30

        Console.WriteLine("text[length] = {0}", text.Length); // 33
    }
}