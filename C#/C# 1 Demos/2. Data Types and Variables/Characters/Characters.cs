using System;

class Characters
{
    static void Main()
    {
        char symbol = 'a';
        Console.WriteLine("The code of '{0}' is: {1}",
			symbol, (int) symbol);  //97

        symbol = 'b';
        Console.WriteLine("The code of '{0}' is: {1}",
			symbol, (int) symbol);  //98

        symbol = 'A';
        Console.WriteLine("The code of '{0}' is: {1}",
			symbol, (int)symbol);   //65

		symbol = 'ù'; // Cyrillic letter 'sht'
		Console.WriteLine("The code of '{0}' is: {1}",
			symbol, (int)symbol);   //1097
    }
}
