using System;

class ChangeEvenBits
{
    static void Main()
    {
        int helperNumbersCount = int.Parse(Console.ReadLine());

        int maxHelperNumber = int.MinValue;
        // намираме най-голямото между въведениете числа, защото неговата дължина ще е най-дълга
        for (int i = 0; i < helperNumbersCount; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number > maxHelperNumber)
            {
                maxHelperNumber = number;
            }
        }

        ulong numberToProcess = ulong.Parse(Console.ReadLine());

        if (maxHelperNumber == int.MinValue)
        {
            Console.WriteLine(numberToProcess);
            Console.WriteLine(0);
            return;
        }

        string maxHelperNumberAsString = Convert.ToString(maxHelperNumber, 2);//конвертираме най-гол.число от двоичен вид в стринг
        int maxBitCount = maxHelperNumberAsString.Length;                     // за да му намерим дължината

        int changedBits = 0;
        for (int position = 0; position < maxBitCount * 2; position += 2)   // обхождаме четните позиции
        {
            if (GetBitAtPosition(numberToProcess, position) == 0)
            {
                changedBits++;
                numberToProcess = SetBitToOne(numberToProcess, position);
            }
        }

        Console.WriteLine(numberToProcess);
        Console.WriteLine(changedBits);
    }

    // method for getting the bit at position from a number
    static ulong GetBitAtPosition(ulong number, int position)
    {
        ulong nRightP = number >> position;
        ulong bit = nRightP & 1;
        return bit;
    }

    // method for setting the bit at position to 0
    static ulong SetBitToZero(ulong number, int position)
    {
        ulong mask = (ulong)(~(1 << position));
        ulong result = number & mask;
        return result;
    }

    // method for setting the bit at position to 1
    static ulong SetBitToOne(ulong number, int position)
    {
        ulong mask = (ulong)(1 << position);
        ulong result = number | mask;
        return result;
    }
}