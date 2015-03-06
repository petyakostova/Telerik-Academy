using System;

class OtherStringOperations
{
    static void Main()
    {
        // String.Replace() example
        string cocktail = "Vodka + Martini + Cherry";
        string replaced = cocktail.Replace("+", "and");
        Console.WriteLine(cocktail);
        Console.WriteLine(replaced);    //Vodka and Martini and Cherry

        // String.Remove() example
        string price = "$ 1234567";
        string lowPrice = price.Remove(2, 3);
        Console.WriteLine(price);
        Console.WriteLine(lowPrice);    //$ 4567

        // Uppercase and lowercase conversion examples
        string alpha = "aBcDeFg";
        string lowerAlpha = alpha.ToLower();    //abcdefg
        Console.WriteLine(lowerAlpha);
        string upperAlpha = alpha.ToUpper();    //ABCDEFG
        Console.WriteLine(upperAlpha);

        // Trim() example
        string s = "  example of white space ";
        string clean = s.Trim();    //example of white space
        Console.WriteLine(clean);

        // Trim(chars) example
        s = " \t\nHello!!! \n";
        clean = s.Trim(' ', ',', '!', '\n', '\t');
        Console.WriteLine(clean);   //Hello

        // TrimStart() example
        s = "   C#   ";
        clean = s.TrimStart();
        Console.WriteLine(clean);   //C#

        // TrimEnd() example
        s = "   C#   ";
        clean = s.TrimEnd();    //   C#
        Console.WriteLine(clean);
    }
}