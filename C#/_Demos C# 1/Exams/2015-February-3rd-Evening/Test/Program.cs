using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "01001";

            string number = "101010111110001001001000010010010010";

            Regex regex = new Regex(pattern);
            Console.WriteLine(regex.Matches(number, 0).Count);


        }
    }
}
