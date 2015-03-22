namespace CatSystem
{
    using System;
    using System.Collections.Generic;

    public class CatSystemStart
    {
        static void Main()
        {
            // create two instances of Owner
            var peshoOwner = new Owner("Pesho", "Ivanov");
            var goshoOwner = new Owner("Gosho", "Petrov");

            //// if get and set are not private => the property Age can be appropriated and changed/edited: 
            //var age = peshoOwner.Age;
            //peshoOwner.Age = 11;

            peshoOwner.IncreaseAge();
            Console.WriteLine(peshoOwner.Age);

            Console.WriteLine(peshoOwner.FullName);

            var cat = new Cat(CatColor.White);
            //whiteCat.Owner = peshoOwner;
            var anotherCat = new Cat(CatColor.Black);
            var yetAnotherCat = new Cat(CatColor.Brown);

            peshoOwner.AddCat(cat, "Dzhinks");
            peshoOwner.AddCat(anotherCat, "Silvestar");

            // this will cause Unhandled Exception: System.NullReferenceException: Object reference not set to an instance of an object. => Line 25 in Owner.cs
            Console.WriteLine(peshoOwner.AllCats);

            // print static property
            Console.WriteLine(Cat.NumberOfLegs);

            // print the result from a static method WhatDoesTheCatSay()
            Console.WriteLine(Cat.WhatDoesTheCatSay());

            // invoke the static method PrintCat() in static class Printer
            Printer.PrintCat(cat);
        }
    }
}
