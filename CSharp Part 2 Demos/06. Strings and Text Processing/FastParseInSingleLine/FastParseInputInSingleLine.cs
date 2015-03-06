using System;
using System.Linq;

class FastParseInputInSingleLine
{
    static void Main()
    {
        // 0 1 2 3 4 5 - даден вход => искаме да прехвърлим числата директно в масив, т.е. съкратено да ги parse-нем

        int[] numbers = Console.ReadLine()
            .Split(new char [] {' '}, 
                StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)  // искаме да го parse-нем; за Select() ни трябва using System.Linq; за всеки стринг, к. получиш => parse                               
            .ToArray(); // направи го на масив

        //other way
        int[] otherNumbers = Console.ReadLine()
            .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

    }
}