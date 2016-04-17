namespace _01.Printing
{
    using System;
    using System.Globalization;
    using System.Threading;

    class Printing
    {

        static void Main()
        {
            const double sheetsPerBox = 500;

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int studentsNumber = int.Parse(Console.ReadLine()); //N
            int paperSheetsForStudent = int.Parse(Console.ReadLine()); //S
            double priceBox = double.Parse(Console.ReadLine()); //P

            double money = (studentsNumber * paperSheetsForStudent) / sheetsPerBox * priceBox;

            Console.WriteLine("{0:F2}", money);

        }
    }
}