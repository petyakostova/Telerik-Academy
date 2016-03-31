//Problem 10. Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//    First name
//    Last name
//    Age (0...100)
//    Gender(m or f)
//    Personal ID number(e.g. 8306112507)
//    Unique employee number(27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class RecordsOfEmployees
{
    static void Main()
    {
        Console.WriteLine("Your first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Your last name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Your age:");
        byte age;
        // parsing and input check (validating the user data)
        while (!byte.TryParse(Console.ReadLine(), out age) || age <= 0 || age >= 100)
        {
            Console.WriteLine("Invalid age.");
            Console.WriteLine("Please enter age in the interval (0;100): ");
        }

        Console.WriteLine("Your gender is (f or m):");
        char gender;
        // parsing and input check (validating the user data)
        while (!char.TryParse(Console.ReadLine(), out gender) || (gender != 'f' && gender != 'm'))
        {
            Console.WriteLine("Invalid gender.");
            Console.WriteLine("Please enter gender (f or m): ");
        }

        Console.WriteLine("Enter your personal ID number:");
        ulong iDNumber;
        // parsing and input check (validating the user data)
        while (!ulong.TryParse(Console.ReadLine(), out iDNumber) || iDNumber == 0)
        {
            Console.WriteLine("Invalid ID number.");
            Console.WriteLine("Please enter your personal ID number (ID > 0): ");
        }

        Console.WriteLine("Enter your unique employee number(from 27560000 to 27569999)");
        int uniqueN;
        // parsing and input check (validating the user data)
        while (!int.TryParse(Console.ReadLine(), out uniqueN) || (uniqueN < 27560000) || (uniqueN > 27569999))
        {
            Console.WriteLine("Invalid employee number.");
            Console.WriteLine("Please enter  your unique employee number(from 27560000 to 27569999): ");
        }

        Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}", firstName, lastName, age);

        if (gender == 'm')
        {
            Console.WriteLine("Your gender is male.");
        }
        else
        {
            Console.WriteLine("Your gender is female.");
        }

        Console.WriteLine("ID number: {0}", iDNumber);
        Console.WriteLine("Unique employee number: {0}", uniqueN);
    }
}