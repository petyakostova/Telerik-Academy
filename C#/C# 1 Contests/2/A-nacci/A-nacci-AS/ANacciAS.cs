using System;

class ANacciAS
{
    static void Main()
    {
        try
        {
            checked
            {
                char firstLetter = Console.ReadLine()[0];
                char secondLetter = Console.ReadLine()[0];

                int rowsToGenerate = int.Parse(Console.ReadLine());

                int firstCode = (firstLetter - 'A') + 1;
                int secondCode = (secondLetter - 'A') + 1;

                int maxCode = 'Z' - 'A' + 1;

                Console.WriteLine(firstLetter);

                if (rowsToGenerate >= 2)
                {
                    Console.Write(secondLetter);

                    int currentCode = firstCode + secondCode;
                    if (currentCode > maxCode)
                    {
                        currentCode = currentCode - maxCode;
                    }

                    firstCode = secondCode;
                    secondCode = currentCode;

                    char currentLetter = (char)(currentCode + 'A' - 1);

                    Console.WriteLine(currentLetter);
                }

                for (int row = 3; row <= rowsToGenerate; row++)
                {
                    int currentCode = firstCode + secondCode;
                    if (currentCode > maxCode)
                    {
                        currentCode = currentCode - maxCode;
                    }

                    firstCode = secondCode;
                    secondCode = currentCode;

                    char currentLetter = (char)(currentCode + 'A' - 1);

                    Console.Write(currentLetter);

                    for (int col = 2; col < row; col++)
                    {
                        Console.Write(" ");
                    }

                    currentCode = firstCode + secondCode;
                    if (currentCode > maxCode)
                    {
                        currentCode = currentCode - maxCode;
                    }

                    firstCode = secondCode;
                    secondCode = currentCode;

                    currentLetter = (char)(currentCode + 'A' - 1);

                    Console.Write(currentLetter);

                    Console.WriteLine();
                }
            }
        }
        catch
        {
            Console.WriteLine();
            Console.WriteLine("arithmetic error or general error");
        }
    }
}