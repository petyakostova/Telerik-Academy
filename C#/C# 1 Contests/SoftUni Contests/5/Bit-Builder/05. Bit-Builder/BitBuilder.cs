using System;

class BitBuilder
{
    static void Main()
    {
        long number = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        while (command != "quit")
        {
            int position = int.Parse(command);
            command = Console.ReadLine();

            // creating mask from ones
            long mask = 0;

            // first way for creating the mask
            string binaryMask = new string('1', position);
            if (position != 0) // important check; otherwise Runtime error in 3 tests
            {
                //long number in binary numeral system
                mask = Convert.ToInt64(binaryMask, 2); // the opposite of Convert.ToString()
            }

            // other way for creating the mask
            //for (int i = 0; i < position; i++)
            //{
            //    mask <<= 1; //shift the mask to the left 1 time for creating space for the one 
            //    mask |= 1; // adding 1 to the mask 
            //}

            long rightBits = number & mask; // the bits to the right, which we want to keep
            /* Explanation:
                position        =>  10                  4               1
                number          =>  000 1111 1110       000 1111 1110   100 1111 1110 
                mask            =>  011 1111 1111       000 0000 1111   000 0000 0001
                number & mask   =>  000 1111 1110       000 0000 1110   000 0000 0000
            */

            switch (command)
            {
                case "flip":
                    number ^= 1 << position;
                    break;
                case "remove":
                    //to avoid mistakes
                    number >>= position + 1; // first: move number to the right (position+1) times 
                    number <<= position; // then: move number to the left (position) times
                    // last: add the right bits, which we keep
                    number |= rightBits; //number = number | rightBits
                    break;
                case "insert":
                    number >>= position;
                    number <<= position + 1; // 1 is the space for the one we want to add
                    //adding the one; 1 must be long, because the position can be 31 (otherwise number will become negative)  
                    number |= (long)1 << position;
                    number |= rightBits; // add the right bits, which we keep
                    break;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(number);
    }
}