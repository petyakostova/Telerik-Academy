using System;
using System.Text;

class RandomPasswordGenerator
{
    private const int MinCapitalLetters = 2;
    private const int MinSmallLetters = 2;
    private const int MinDigits = 1;
    private const int MinSpecialChars = 3;
    private const int MaxPasswordLength = 15;
    private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
    private const string Digits = "0123456789";
    private const string SpecialChars = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";
    private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialChars;
    private static readonly Random rnd = new Random();

    static void Main()
    {
        StringBuilder password = new StringBuilder();   // using System.Text;

        for (int i = 1; i <= MinCapitalLetters; i++)
        {
            char capitalLetter = GenerateChar(CapitalLetters);
            InsertAtRandomPosition(password, capitalLetter);
        }
        for (int i = 1; i <= MinSmallLetters; i++)
        {
            char smallLetter = GenerateChar(SmallLetters);
            InsertAtRandomPosition(password, smallLetter);
        }
        for (int i = 1; i <= MinDigits; i++)
        {
            char digit = GenerateChar(Digits);
            InsertAtRandomPosition(password, digit);
        }
        for (int i = 1; i <= MinSpecialChars; i++)
        {
            char specialChar = GenerateChar(SpecialChars);
            InsertAtRandomPosition(password, specialChar);
        }
        int maxAdditionalChars = MaxPasswordLength - password.Length;
        int additionalCharsCount = rnd.Next(maxAdditionalChars + 1);
        for (int i = 1; i <= additionalCharsCount; i++)
        {
            char specialChar = GenerateChar(AllChars);
            InsertAtRandomPosition(password, specialChar);
        }
        Console.WriteLine(password);
    }

    private static void InsertAtRandomPosition(
        StringBuilder password, char character)
    {
        int randomPosition = rnd.Next(password.Length + 1);
        password.Insert(randomPosition, character);
    }

    private static char GenerateChar(string availableChars)
    {
        int randomIndex = rnd.Next(availableChars.Length);
        char randomChar = availableChars[randomIndex];
        return randomChar;
    }

}