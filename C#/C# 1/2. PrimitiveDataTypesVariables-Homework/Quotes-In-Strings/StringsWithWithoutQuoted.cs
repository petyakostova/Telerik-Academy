//Problem 7. Quotes in Strings
//Description => Write a program that outputs The "use" of quotations causes difficulties.
//Input => None
//Output => Print on a single line 
//The "use" of quotations causes difficulties.

using System;
class StringsWithWithoutQuoted
{
    static void Main()
    {
        // first way - with using quoted strings
        string withQuoted = @"The ""use"" of quotations causes difficulties.";
        // second way - without using quoted strings
        string withoutQuoted = "The \"use\" of quotations causes difficulties.";
        //Console.WriteLine("With quoted strings: {0}\nWithout quoted strings: {1}", withQuoted, withoutQuoted);

        Console.WriteLine(withQuoted);
        //Console.WriteLine(withoutQuoted);
    }
}