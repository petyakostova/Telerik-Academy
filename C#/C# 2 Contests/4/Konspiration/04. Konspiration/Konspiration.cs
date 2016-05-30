namespace _04.Konspiration
{
    using System;
    using System.Collections.Generic; // List<string>
    using System.Linq; // Contains()

    // Observations:
    // all methods will begin with static keyword
    // all methods will have (...) on the same line
    // all methods will have { ot the next line
    // get method bodies by splitting by " static " or by counting brackets
    // all method calls and names will begin with capital letter
    // need to handle the new keyword

    class Konspiration
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); // number of lines

            // array of strings for the lines
            string[] lines = new string[n];
            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            // other way for array input
            //string[] lines2 = Enumerable.Range(0, n).Select(x => Console.ReadLine()).ToArray();

            for (int i = 0; i < n; i++)
            {
                if (lines[i].Contains(" static "))
                {
                    string name = lines[i].Split(new[] { ' ', '(' }, StringSplitOptions.RemoveEmptyEntries)[2];

                    // the next line after the line with the method name is { 
                    // => so skip it and go to the next one
                    i += 2;

                    // in the beginning we have 1 open bracket
                    int openBrackets = 1;

                    List<string> methodCalls = new List<string>();

                    while (openBrackets > 0 && i < n)
                    {
                        var splitByRoundBracket = lines[i].Split('(');

                        if (splitByRoundBracket.Length > 1)
                        {
                            for (int k = 0; k < splitByRoundBracket.Length - 1; k++)
                            {
                                var methodName = ExtractMethodName(splitByRoundBracket[k]);

                                if (methodName != null)
                                {
                                    methodCalls.Add(methodName);
                                }
                            }
                        }

                        // counting the brackets
                        foreach (var symbol in lines[i])
                        {
                            if (symbol == '{')
                            {
                                openBrackets++;
                            }
                            else if (symbol == '}')
                            {
                                openBrackets--;
                            }
                        }

                        i++;
                    }

                    if (methodCalls.Count > 0)
                    {
                        Console.WriteLine(name + " -> "
                            + methodCalls.Count + " -> "
                            + string.Join(", ", methodCalls));
                    }
                    else
                    {
                        Console.WriteLine(name + " -> None");
                    }
                }
            }
        }

        // extract method name from piece of code
        static string ExtractMethodName(string codePiece)
        {
            var beforeBracket = codePiece.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            // trim operators that can precede a method invoke
            var methodName = beforeBracket[beforeBracket.Length - 1]
                .TrimStart("<>!+-*/%^~".ToCharArray());
            /* public String TrimStart(params char[] trimChars); 
               Removes all leading occurrences of a set of characters specified in an array from the current System.String object.    
             Parameters: trimChars => An array of Unicode characters to remove, or null.
             Returns: The string that remains after all occurrences of characters in the trimChars parameter 
             are removed from the start of the current string. 
             If trimChars is null or an empty array, white-space characters are removed instead. */

            if (methodName.Length == 0 || !char.IsUpper(methodName[0]) || beforeBracket.Contains("new"))
            {
                return null;
            }

            return methodName;
        }

    }
}