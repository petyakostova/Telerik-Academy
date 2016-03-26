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
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Your Gender is (f or m):");
        char gender = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter your personal ID number:");
        ulong iDNumber = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Enter your unique employee number(from 27560000 to 27569999)");
        int uniqueN = int.Parse(Console.ReadLine());
        Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}", firstName, lastName, age);
        if (gender == 'm')
        {
            Console.WriteLine("Your gender is male.");
        }
        else if (gender == 'f')
        {
            Console.WriteLine("Your gender is female.");
        }
        else
        {
            Console.WriteLine("Wrong symbol for gender.");
        }

        if (iDNumber < 0)
        {
            Console.WriteLine("Wrong ID number.");
        }
        else
        {
            Console.WriteLine("ID number: {0}", iDNumber);
        }

        if (uniqueN < 27560000)
        {
            Console.WriteLine("Wrong unique employee number.");
        }
        else if (uniqueN > 27569999)
        {
            Console.WriteLine("Wrong unique employee number.");
        }
        else
        {
            Console.WriteLine("Unique employee number: {0}", uniqueN);
        }
    }
}