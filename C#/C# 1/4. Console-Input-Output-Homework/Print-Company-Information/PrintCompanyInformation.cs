/*Problem 2. Print Company Information
A company has name, address, phone number, fax number, web site and manager. 
The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.

Example input:                                              Example output:
program 	            user
Company name: 	        Telerik Academy                     Telerik Academy
Company address: 	    31 Al. Malinov, Sofia               Address: 231 Al. Malinov, Sofia
Phone number: 	        +359 888 55 55 555                  Tel. +359 888 55 55 555
Fax number: 	                                            Fax: (no fax)
Web site: 	            http://telerikacademy.com/          Web site: http://telerikacademy.com/
Manager first name: 	Nikolay                             Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)
Manager last name: 	    Kostov
Manager age: 	        25
Manager phone: 	        +359 2 981 981
*/

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter a Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter a Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter a Phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Enter a Fax number: ");
        string companyFax = Console.ReadLine();
        if (companyFax == "")
        {
            companyFax = "(no fax)";
        }
        Console.Write("Enter a Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter a Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter a Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter a Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Enter a Manager phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("\r\n" + companyName + "\r\n" + "Address: " + companyAddress + "\r\n" + "Tel. " + companyPhone);
        Console.WriteLine("Fax: " + companyFax + "\r\n" + "Web site: " + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}