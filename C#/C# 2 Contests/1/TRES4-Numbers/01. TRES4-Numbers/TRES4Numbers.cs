namespace _01.TRES4_Numbers
{
    using System;
    using System.Text; // StringBuilder

    class TRES4Numbers
    {
        static void Main()
        {
            //Console.WriteLine(long.MaxValue); // 9223372036854775807 => no
            //Console.WriteLine(ulong.MaxValue); // 18446744073709551615 => yes
            int numeralSystem = 9;

            string[] digits = new[] {
            "LON+", "VK-", "*ACAD",
            "^MIM", "ERIK|", "SEY&",
            "EMY>>", "/TEL", "<<DON" };

            ulong numberInDecimal = ulong.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            // using do-while because of the case with input 0 
            // to convert the number from 9th do decimal numeral system
            do
            {
                int digitIn9th = (int)(numberInDecimal % (ulong)numeralSystem); // will be in range [0; 8]
                result.Insert(0, digits[digitIn9th]);   // insert digits[digitIn9th] in the beginning of the result
                numberInDecimal /= (ulong)numeralSystem;
            }
            while (numberInDecimal > 0);

            Console.WriteLine(result.ToString());
        }
    }
}