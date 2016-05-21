using System;

class StringConcatenation
{
    static void Main()
    {
        string firstName = "Svetlin";
        string lastName = "Nakov";

        string fullName = firstName + " " + lastName;
        Console.WriteLine(fullName);    // Svetlin Nakov

        int age = 25;

        string nameAndAge = "Name: " + fullName // Name: Svetlin Nakov
            + "\nAge: " + age;                  // Age: 25

        Console.WriteLine(nameAndAge);
    }
}