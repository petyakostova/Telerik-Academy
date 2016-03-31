/* 2. Company Info  
   A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console. Make sure that you print "(no fax)" if an empty line is passed as fax number. */

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string companyPhone = Console.ReadLine();
        string companyFax = Console.ReadLine();
        if (companyFax == "")
        {
            companyFax = "(no fax)";
        }
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int managerAge = int.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();

        Console.WriteLine("{0}\r\nAddress: {1}\r\nTel. {2}\r\nFax: {3}\r\nWeb site: {4}", companyName, companyAddress, companyPhone, companyFax, webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}