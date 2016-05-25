using System;
using System.Text;

class PasswordGenerator
{
    static Random rndGenerator = new Random();

    static void InsertRandomSymbols(int count, StringBuilder password, string symbols)
    {
        for (int i = 0; i < count; i++)
        {
            char symbol = symbols[rndGenerator.Next(0, symbols.Length)];
            int randomPosition = rndGenerator.Next(0, password.Length);
            password.Insert(randomPosition, symbol);
        }
    }

    static void Main()
    {
        string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //char[] capitalLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        string lowerLetters = "abcdefghijklmnopqrstuvwxyz"; // google: c# alphabet string
        string digits = "0123456789";
        string specialSymbols = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";

        //Random rndGenerator = new Random(); // without method()

        StringBuilder password = new StringBuilder();

        InsertRandomSymbols(2, password, capitalLetters);
        InsertRandomSymbols(2, password, lowerLetters);
        InsertRandomSymbols(1, password, digits);
        InsertRandomSymbols(3, password, specialSymbols);

        InsertRandomSymbols(rndGenerator.Next(0, 7), password, capitalLetters + lowerLetters + digits + specialSymbols);

        // without method()
        //for (int i = 0; i < 2; i++)
        //{
        //    char symbol = capitalLetters[rndGenerator.Next(0, capitalLetters.Length)];
        //    // .Append() put them consistently, thats why we use Insert()
        //    int randomPosition = rndGenerator.Next(0, password.Length);
        //    password.Insert(randomPosition, symbol); // inserts the symbol at random position
        //}

        //for (int i = 0; i < 2; i++)
        //{
        //    char symbol = lowerLetters[rndGenerator.Next(0, lowerLetters.Length)];
        //    int randomPosition = rndGenerator.Next(0, password.Length);
        //    password.Insert(randomPosition, symbol);
        //}

        //for (int i = 0; i < 1; i++)
        //{
        //    char symbol = digits[rndGenerator.Next(0, digits.Length)];
        //    int randomPosition = rndGenerator.Next(0, password.Length);
        //    password.Insert(randomPosition, symbol);
        //}

        //for (int i = 0; i < 3; i++)
        //{
        //    char symbol = specialSymbols[rndGenerator.Next(0, specialSymbols.Length)];
        //    int randomPosition = rndGenerator.Next(0, password.Length);
        //    password.Insert(randomPosition, symbol);
        //}

        Console.WriteLine(password.ToString());
    }
}