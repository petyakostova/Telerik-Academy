using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TextToNumber.Solution
{
    class TextToNumberApp
    {
        static void Main()
        {
            BigInteger result = 0;

            int module = int.Parse(Console.ReadLine());

            var ch = (char)Console.Read();
            //string resultAsString = string.Empty;

            while (ch != '@')
            {
                if (ch == '@')
                {
                    break;
                }
                if (char.IsDigit(ch))
                {
                    //resultAsString += "RESULT = " + result + " * " + (ch - '0') + "(" + ch + ") = ";
                    result *= ch - '0';
                    //resultAsString += result;
                }
                else if (char.IsLetter(ch))
                {
                    if ('A' <= ch && ch <= 'Z')
                    {
                        //resultAsString += "RESULT = " + result + " + " + (ch - 'A') + "(" + ch + ") = ";
                        result += ch - 'A';
                        //resultAsString += result;
                    }
                    else
                    {
                        //resultAsString += "RESULT = " + result + " + " + (ch - 'a') + "(" + ch + ") = ";
                        result += ch - 'a';
                        //resultAsString += result;
                    }
                }
                else
                {
                    //resultAsString += "RESULT = " + result + " % " + module + "(" + ch + ") = ";
                    result %= module;
                    //resultAsString += result;
                }
                ch = (char)Console.Read();
                //resultAsString += Environment.NewLine;
            }
            Console.WriteLine("{0}", result);
            //Console.WriteLine(resultAsString);
        }
    }
}