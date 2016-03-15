using System;

class ValueTypes
{
    static void Main()
    {
        int number = 100;
        SetValue(number);

        Console.WriteLine(number);  // 100
        /* Когато имаме примитивни типове (структури - стойностни типове) и ги подаваме/взимаме/ на методи,
           те всеки път се създават наново (заделя се нова памет)
         * Ако беше масив, щеше да се промени (защото е референтен тип), 
           защото на метода се подава референция в коя част на паметта се намира
         */
    }

    static void SetValue(int number)
    {
        number = 42;
    }
}