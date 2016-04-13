using System;

class ChangeEvenBits
{
    static void Main()
    {
        int helperNumbersCount = int.Parse(Console.ReadLine());

        int maxHelperNumber = int.MinValue; //-2147483648 => 1111111111111111111111111111111110000000000000000000000000000000

        // find the biggest of inputed numbers, because it's length will be the biggest
        for (int i = 0; i < helperNumbersCount; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number > maxHelperNumber)
            {
                maxHelperNumber = number;
            }
        }

        ulong numberToProcess = ulong.Parse(Console.ReadLine());

        //check
        if (maxHelperNumber == int.MinValue)
        {
            Console.WriteLine(numberToProcess);
            Console.WriteLine(0);
            return;
        }

        // concatenatе the biggest number from binary form in string
        string maxHelperNumberAsString = Convert.ToString(maxHelperNumber, 2);

        // to find its length
        int maxBitCount = maxHelperNumberAsString.Length;                     

        int changedBits = 0;
        for (int position = 0; position < maxBitCount * 2; position += 2)   
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
    
    // method for setting the bit at position to 1
    static ulong SetBitToOne(ulong number, int position)
    {
        ulong mask = (ulong)(1 << position);
        ulong result = number | mask;
        return result;
    }

    // method for setting the bit at position to 0
    //static ulong SetBitToZero(ulong number, int position)
    //{
    //    ulong mask = (ulong)(~(1 << position));
    //    ulong result = number & mask;
    //    return result;
    //}
}