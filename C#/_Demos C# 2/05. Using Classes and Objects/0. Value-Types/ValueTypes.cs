using System;

class ValueTypes
{
    static void Main()
    {
        int number = 100;
        SetValue(number);

        Console.WriteLine(number);  // 100
    }

    static void SetValue(int number)
    {
        number = 42;
    }
}