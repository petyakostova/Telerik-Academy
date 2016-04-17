namespace _01.Money
{
    using System;
    using System.Threading;
    using System.Globalization;

    class Money
    {
        static void Main()
        {
            const double sheetsPerBox = 400;

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            
            int studentsNumber = int.Parse(Console.ReadLine()); //N
            int paperSheetsForStudent = int.Parse(Console.ReadLine()); //S
            double priceBox = double.Parse(Console.ReadLine()); //P

            double money = (studentsNumber * paperSheetsForStudent) / sheetsPerBox * priceBox;

            Console.WriteLine("{0:F3}", money);
            
        }
    }
}