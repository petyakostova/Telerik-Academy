using System;

class NeuronMapping
{
    static void Main() 
    {
        const uint BIT = (uint)1;
        
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "-1")
            {
                break;
            }

            uint thisRow = uint.Parse(input);
            
            uint output = 0;
            
            bool isInside = false;
            
            int oneBitSequences = 0;
            
            for (int ii = 0; ii < 32; ++ii) 
            {
                uint mask = (BIT << ii);
                
                if ((thisRow & mask) == 0)
                {
                    if (isInside)
                        output |= mask;
                    continue;
                }
                else
                {
                    oneBitSequences += 1;
                    isInside = !isInside;
                    while (ii < 32 && (thisRow & (BIT << ii)) != 0)
                    {
                        ii += 1;
                    }
                    // back off one step,
                    // the for loop will increment the counter anyway
                    ii -= 1;
                }
            }
            
            if (oneBitSequences != 2) 
            {
                output = 0;
            }
            
            Console.WriteLine(output);
        }
    }
}
