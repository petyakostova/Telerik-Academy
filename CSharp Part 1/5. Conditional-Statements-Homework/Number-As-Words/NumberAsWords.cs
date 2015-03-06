/* Problem 11.* Number as Words
   Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
Examples:
numbers 	number as words
0 	        Zero
9 	        Nine
10 	        Ten
12 	        Twelve
19 	        Nineteen
25 	        Twenty five
98 	        Ninety eight
98 	        Ninety eight
273 	    Two hundred and seventy three
400 	    Four hundred
501 	    Five hundred and one
617 	    Six hundred and seventeen
711 	    Seven hundred and eleven
999 	    Nine hundred and ninety nine
*/

using System;
class NumberAsWords
{
    static void Main()
    {
        Console.Write("Enter number in the interval [0...999]: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || (number < 0 || number > 999))
        {
            Console.Write("Incorrect input data! Enter number in the interval [0...999]: ");
        }
        string num = number.ToString();
        if (number >= 100 && number <= 999)
        {
            switch (num[0])
            {
                case '1': Console.Write("One hundred "); break;
                case '2': Console.Write("Two hundred "); break;
                case '3': Console.Write("Three hundred "); break;
                case '4': Console.Write("Four hundred "); break;
                case '5': Console.Write("Five hundred "); break;
                case '6': Console.Write("Six hundred "); break;
                case '7': Console.Write("Seven hundred "); break;
                case '8': Console.Write("Eight hundred "); break;
                case '9': Console.Write("Nine hundred "); break;
            }
            if (num[1] == '0')
            {
                switch (num[2])
                {
                    case '1': Console.WriteLine("and one"); break;
                    case '2': Console.WriteLine("and two"); break;
                    case '3': Console.WriteLine("and three"); break;
                    case '4': Console.WriteLine("and four"); break;
                    case '5': Console.WriteLine("and five"); break;
                    case '6': Console.WriteLine("and six"); break;
                    case '7': Console.WriteLine("and seven"); break;
                    case '8': Console.WriteLine("and eight"); break;
                    case '9': Console.WriteLine("and nine"); break;
                }
            }
            else if (num[1] == '1')
            {
                switch (num[2])
                {
                    case '0': Console.WriteLine("and ten"); break;
                    case '1': Console.WriteLine("and eleven"); break;
                    case '2': Console.WriteLine("and twelve"); break;
                    case '3': Console.WriteLine("and thirteen"); break;
                    case '4': Console.WriteLine("and fourteen"); break;
                    case '5': Console.WriteLine("and fifteen"); break;
                    case '6': Console.WriteLine("and sixteen"); break;
                    case '7': Console.WriteLine("and seventeen"); break;
                    case '8': Console.WriteLine("and eighteen"); break;
                    case '9': Console.WriteLine("and nineteen"); break;
                }
            }
            else if (num[1] != '1')
            {
                switch (num[1])
                {
                    case '2': Console.Write("and twenty "); break;
                    case '3': Console.Write("and thirty "); break;
                    case '4': Console.Write("and fourty "); break;
                    case '5': Console.Write("and fifty "); break;
                    case '6': Console.Write("and sixty "); break;
                    case '7': Console.Write("and seventy "); break;
                    case '8': Console.Write("and eighty "); break;
                    case '9': Console.Write("and ninety "); break;
                }
                if (num[2] != '0')
                {
                    switch (num[2])
                    {
                        case '1': Console.WriteLine("one"); break;
                        case '2': Console.WriteLine("two"); break;
                        case '3': Console.WriteLine("three"); break;
                        case '4': Console.WriteLine("four"); break;
                        case '5': Console.WriteLine("five"); break;
                        case '6': Console.WriteLine("six"); break;
                        case '7': Console.WriteLine("seven"); break;
                        case '8': Console.WriteLine("eight"); break;
                        case '9': Console.WriteLine("nine"); break;
                    }
                }
            }
        }
        if (number >= 20 && number < 100)
        {
            switch (num[0])
            {
                case '2': Console.Write("Twenty "); break;
                case '3': Console.Write("Thirty "); break;
                case '4': Console.Write("Fourty "); break;
                case '5': Console.Write("Fifty "); break;
                case '6': Console.Write("Sixty "); break;
                case '7': Console.Write("Seventy "); break;
                case '8': Console.Write("Eighty "); break;
                case '9': Console.Write("Ninety "); break;
            }
            if (num[1] != '0')
            {
                switch (num[1])
                {
                    case '1': Console.WriteLine("one"); break;
                    case '2': Console.WriteLine("two"); break;
                    case '3': Console.WriteLine("three"); break;
                    case '4': Console.WriteLine("four"); break;
                    case '5': Console.WriteLine("five"); break;
                    case '6': Console.WriteLine("six"); break;
                    case '7': Console.WriteLine("seven"); break;
                    case '8': Console.WriteLine("eight"); break;
                    case '9': Console.WriteLine("nine"); break;
                }
            }
        }
        if (number >= 10 && number <= 19)
        {
            switch (num[1])
            {
                case '0': Console.WriteLine("Ten"); break;
                case '1': Console.WriteLine("Eleven"); break;
                case '2': Console.WriteLine("Twelve"); break;
                case '3': Console.WriteLine("Thirteen"); break;
                case '4': Console.WriteLine("Tourteen"); break;
                case '5': Console.WriteLine("Fifteen"); break;
                case '6': Console.WriteLine("Sixteen"); break;
                case '7': Console.WriteLine("Seventeen"); break;
                case '8': Console.WriteLine("Eighteen"); break;
                case '9': Console.WriteLine("Nineteen"); break;
            }
        }
        if (number >= 1 && number <= 9)
        {
            switch (num[0])
            {
                case '1': Console.WriteLine("One"); break;
                case '2': Console.WriteLine("Two"); break;
                case '3': Console.WriteLine("Three"); break;
                case '4': Console.WriteLine("Four"); break;
                case '5': Console.WriteLine("Five"); break;
                case '6': Console.WriteLine("Six"); break;
                case '7': Console.WriteLine("Seven"); break;
                case '8': Console.WriteLine("Eight"); break;
                case '9': Console.WriteLine("Nine"); break;
            }
        }
        else if (num[0] == '0')
        {
            Console.WriteLine("Zero");
        }
        Console.WriteLine();
    }
}