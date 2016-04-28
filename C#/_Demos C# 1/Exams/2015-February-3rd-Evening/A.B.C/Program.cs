namespace A.B.C
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(a,Math.Max(b,c)));
            Console.WriteLine(Math.Min(a, Math.Min(b, c)));
            Console.WriteLine(String.Format("{0:F3}", (a + b + c) / 3.0));
        }
    }
}
