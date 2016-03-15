namespace Action_And_Func
{
    using System;
    using System.Collections.Generic;

    public static class ActionAndFunc
    {
        public static void Main()
        {
            // Action<int> logNumber = Console.WriteLine;
            Action<int> logNumber = (number) => Console.WriteLine(number);
            logNumber(5);//5

            Action<string, int> logNameAge = (name, age) =>
                {
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Age: " + age);
                };
            logNameAge("Pesho", 5);
            //Name: Pesho
            //Age: 5

            // Func<string> magic = () => "Magic";
            Func<string> magic = () =>
            {
                return "Magic";
            };
            Console.WriteLine(magic());//Magic

            Func<string, int> parser = int.Parse;
            int someNumber = parser("50");
            Console.WriteLine(someNumber);//50

            string[] someStrings = { "Pesho", "Ivaylo", "Gosho", "Niki" };
            someStrings.Each(Console.WriteLine);
            //Pesho
            //Ivaylo
            //Gosho
            //Niki
            someStrings.Each(str =>
                {
                    Console.Write(str + " ");//Pesho Ivaylo Gosho Niki
                });
            Console.WriteLine();
            //// Array.ForEach(someStrings, Console.WriteLine);
        }

        public static void Each<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }
    }
}
