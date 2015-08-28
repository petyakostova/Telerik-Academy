//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account 
//using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        Console.WriteLine("Enter your first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter your middle name");
        string middleName = Console.ReadLine();

        Console.WriteLine("Enter your last name");
        string lastName = Console.ReadLine();

        Console.WriteLine("Your first name is: {0}\nYour middle name is: {1}\nYour last name is: {2}", firstName, middleName, lastName);

        decimal balance = 5000;
        Console.WriteLine("Available bank balance: {0}", balance);

        string bankName = "UniCredit Bulbank";
        Console.WriteLine("Your bank is {0}", bankName);

        string iBAN = "BGN07FFUU87005555735555";
        Console.WriteLine("IBAN / {0}", iBAN);

        ulong creditCard1 = 5370961434345976;
        Console.WriteLine("The number of your first credit card is: {0}", creditCard1);

        ulong creditCard2 = 1485349943514587;
        Console.WriteLine("The number of your second credit card is: {0}", creditCard2);

        ulong creditCard3 = 5474743873758712;
        Console.WriteLine("The number of your third credit card is: {0}", creditCard3);
    }
}