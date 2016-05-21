/*  1. Strings in C#.
    Describe the strings in C#. What is typical for the string data type? 
    Describe the most important methods of the String class.
 */

using System;
using System.Text;

class StringsInCSharp
{
    static void Main()
    {
        Console.BufferHeight = 80;
        Console.WriteLine("1) Describe the strings in C#:\n");
        DescribingStrings();
        Console.WriteLine("2) What is typical for the string data type?\n");
        TypicalForStringDataType();
        Console.WriteLine("3) Describe the most important methods of the String class:\n");
        ImportantMethodsOfTheStringClass();
    }

    private static void DescribingStrings()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Strings are immutable (read-only) sequences of characters,\n represented by the string data type in C# (System.String).");
        sb.AppendLine("Use Unicode to support multiple languages and alphabets.");
        sb.AppendLine("Declared by the keyword string in C#.");
        sb.AppendLine("Strings are stored in the dynamic memory (managed heap).");
        Console.WriteLine(sb);
    }

    private static void TypicalForStringDataType()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("System.String is reference type.");
        sb.AppendLine("The value of the String object is the content of the sequential collection\n and that value is immutable (it is read-only).");
        sb.AppendLine("The maximum size of a String object in memory is 2 GB, or about 1 billion characters. ");
        sb.AppendLine("This type allows us to manipulate character data through different methods and properties.");
        sb.AppendLine("String objects are like arrays of characters (char[]).");
        sb.AppendLine("Elements can be accessed directly by index.\n The index is in the range [0...Length-1].");
        sb.AppendLine("Have fixed length (String.Length).");        
        Console.WriteLine(sb);
    }

    private static void ImportantMethodsOfTheStringClass()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Most important methods of the String class are:");
        sb.AppendLine("1.  Length => Get length of the string");
        sb.AppendLine("2.  str[index] => Indexer in C#; gives access to the char value at given position");
        sb.AppendLine("3.  string.Compare(str1, str2) or str1.CompareTo(str2) => Comparison of the two strings.\n    Returns 0 if str1 equals str2. Returns -1 if str1 is before str2. Returns 1 if str1 is after str2.");
        sb.AppendLine("4.  str.IndexOf(strSearch) => Returns the start index of the substring strSearch in str\n    by its first occurrences");
        sb.AppendLine("5.  str.LastIndexOf(strSearch) => Returns the start index of the substring strSearch in str\n    by its last occurrences");
        sb.AppendLine("6.  Substring(startIndex, length) => Returns the substring from startIndex with given length");
        sb.AppendLine("7.  Replace(oldStr, newStr) => Replaces all occurrences of given string oldStr with newStr");
        sb.AppendLine("8.  Remove(startIndex, length) => Deletes part of a string and produces new string as result;\n    removes the characters from startIndex to given length");
        sb.AppendLine("9.  ToUpper() => Convert to uppercase");
        sb.AppendLine("10. ToLower() => Convert to lowercase ");
        sb.AppendLine("11. Trim() => Remove leading and trailing whitespace");
        sb.AppendLine("12. ToString() => Convert objects to strings ");
        sb.AppendLine("13. Split() => Split string by given char/s");
        sb.AppendLine("14. string.Concat(str1, str2) => Concatenates 2 strings");        
        Console.WriteLine(sb);
    }
}