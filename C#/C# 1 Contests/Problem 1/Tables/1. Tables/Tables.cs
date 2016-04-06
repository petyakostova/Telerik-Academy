using System;

class Tables
{
    static void Main()
    {
        // 999999999*4 = 3 999 999 996; int (2 147 483 647) => must be long
        long bundle1 = long.Parse(Console.ReadLine());
        long bundle2 = long.Parse(Console.ReadLine());
        long bundle3 = long.Parse(Console.ReadLine());
        long bundle4 = long.Parse(Console.ReadLine());
        long tableTops = long.Parse(Console.ReadLine());
        long tablesToBeMade = long.Parse(Console.ReadLine());

        long totalLegs = bundle1 + bundle2 * 2 + bundle3 * 3 + bundle4 * 4; // all legs, which we have
        long tablesMade = Math.Min(tableTops, totalLegs / 4);   // tables, which can be made

        if (tablesMade > tablesToBeMade) // tables, which can be made > tables, which have to be made
        {
            long topsLeft = tableTops - tablesToBeMade;         
            long legsLeft = totalLegs - tablesToBeMade * 4;        

            Console.WriteLine("more: {0}", tablesMade - tablesToBeMade); // how many more tables could be made 
            Console.WriteLine("tops left: {0}, legs left: {1}", topsLeft, legsLeft);    
        }
        else if (tablesMade < tablesToBeMade)  
        {
            long topsNeeded;    
            long legsNeeded;    

            if (tablesToBeMade >= tableTops)
            {
                topsNeeded = tablesToBeMade - tableTops;
            }
            else
            {
                topsNeeded = 0;
            }
            if (tablesToBeMade * 4 >= totalLegs)
            {
                legsNeeded = tablesToBeMade * 4 - totalLegs;
            }
            else
            {
                legsNeeded = 0;
            }
            Console.WriteLine("less: {0}", tablesMade - tablesToBeMade);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", topsNeeded, legsNeeded);
        }
        else
        {
            Console.WriteLine("Just enough tables made: {0}", tablesMade);
        }

    }
}