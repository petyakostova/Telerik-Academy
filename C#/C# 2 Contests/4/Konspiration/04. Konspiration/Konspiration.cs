namespace _04.Konspiration
{
    using System;
    using System.Collections.Generic; // List<string>
    using System.Linq; // Contains()

    class Konspiration
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                if (lines[i].Contains(" static "))
                {
                    var name = lines[i].Split(new[] { ' ', '(' }, StringSplitOptions.RemoveEmptyEntries)[2];

                    i += 2;

                    var openBrackets = 1;
                    var methodCalls = new List<string>();

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

        static string ExtractMethodName(string codePiece)
        {
            var beforeBracket = codePiece.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            // trim operators that can precede a method invoke
            var methodName = beforeBracket[beforeBracket.Length - 1].TrimStart("<>!+-*/%^~".ToCharArray());

            if (methodName.Length == 0 || !char.IsUpper(methodName[0]) || beforeBracket.Contains("new"))
            {
                return null;
            }

            return methodName;
        }

    }
}