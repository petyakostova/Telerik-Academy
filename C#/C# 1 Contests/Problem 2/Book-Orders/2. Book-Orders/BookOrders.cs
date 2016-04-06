using System;

class BookOrders
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int books = 0;
        decimal price = 0;

        for (int i = 0; i < n; i++)
        {
            int packets = int.Parse(Console.ReadLine());
            int booksInPacket = int.Parse(Console.ReadLine());
            decimal pricePerBook = decimal.Parse(Console.ReadLine());

            int booksTotal = packets * booksInPacket;

            decimal priceTotal = 0m;

            if (packets >= 10 && packets < 20)
            {
                priceTotal = booksTotal * pricePerBook * 0.95m;
            }
            else if (packets >= 20 && packets < 30)
            {
                priceTotal = booksTotal * pricePerBook * 0.94m;
            }
            else if (packets >= 30 && packets < 40)
            {
                priceTotal = booksTotal * pricePerBook * 0.93m;
            }
            else if (packets >= 40 && packets < 50)
            {
                priceTotal = booksTotal * pricePerBook * 0.92m;
            }
            else if (packets >= 50 && packets < 60)
            {
                priceTotal = booksTotal * pricePerBook * 0.91m;
            }
            else if (packets >= 60 && packets < 70)
            {
                priceTotal = booksTotal * pricePerBook * 0.90m;
            }
            else if (packets >= 70 && packets < 80)
            {
                priceTotal = booksTotal * pricePerBook * 0.89m;
            }
            else if (packets >= 80 && packets < 90)
            {
                priceTotal = booksTotal * pricePerBook * 0.88m;
            }
            else if (packets >= 90 && packets < 100)
            {
                priceTotal = booksTotal * pricePerBook * 0.87m;
            }
            else if (packets >= 100 && packets < 110)
            {
                priceTotal = booksTotal * pricePerBook * 0.86m;
            }
            else if (packets >= 110)
            {
                priceTotal = booksTotal * pricePerBook * 0.85m;
            }
            else
            {
                // when there is no discount
                priceTotal = booksTotal * pricePerBook;
            }

            books += booksTotal;
            price += priceTotal;
        }

        Console.WriteLine(books);
        Console.WriteLine("{0:0.00}", price);
    }
}