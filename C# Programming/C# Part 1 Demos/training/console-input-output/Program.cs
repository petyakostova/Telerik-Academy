using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace console_input_output
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("{0, -10} other text", 555);
            //Console.WriteLine("{0:# 'text'}", 555);

            //int num2 = (char)Console.Read() - '0';
            //Console.WriteLine(num2);

            //try
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    Console.WriteLine("it's ok");
            //    Console.WriteLine(num);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Error");
            //}
            //Console.WriteLine("code continues");

            //string input = Console.ReadLine();
            //int num;
            //bool canParse = int.TryParse(input, out num);
            //if (canParse)
            //{
            //    Console.WriteLine("OK");
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //}

            //string str;
            //int num;
            //do
            //{
            //    Console.WriteLine("Please enter a number: ");
            //    str = Console.ReadLine();
            //} 
            //while (!int.TryParse(str, out num));

            //Console.OutputEncoding = Encoding.UTF8;
            //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //string input = Console.ReadLine();
            ////input = 
            //Console.WriteLine(input);

            //string input = Console.ReadLine();  // "1 2 3 4 5"
            //int sum = 0;
            //string[] numStr = input.Split(new char[] {' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < numStr.Length; i++) // length = 5
            //{
            //    sum += int.Parse(numStr[i]); 
            //}
            //Console.WriteLine(sum);

            //int length = int.Parse(Console.ReadLine());
            //int[] nums = new int[length];
            //for (int i = 0; i < length; i++)    // length = nums.Length
            //{
            //    nums[i] = int.Parse(Console.ReadLine());
            //}

            //int year = 2015;
            //int month = 1;
            //int day = 22;
            //DateTime date = new DateTime(year, month, day);
            //Console.WriteLine(date.ToString("dd-dddd-MMM-yyyy"));


        }
    }
}
