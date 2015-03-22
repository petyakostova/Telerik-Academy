namespace CatSystem
{
    using System;
    using System.Collections.Generic;

    public class CatSystemStart
    {
        public static void ChangeCatName(Cat cat)
        {
            cat.Name = "Johny";
        }

        public static void Main()
        {
            // create two instances of Owner
            var peshoOwner = new Owner("Pesho", "Ivanov");
            var goshoOwner = new Owner("Gosho", "Petrov");

            //// if get and set are not private => the property Age can be appropriated and changed/edited: 
            //var age = peshoOwner.Age;
            //peshoOwner.Age = 11;

            peshoOwner.IncreaseAge();
            Console.WriteLine(peshoOwner.Age);  //1

            Console.WriteLine(peshoOwner.FullName); // Pesho Ivanov

            var cat = new Cat(CatColor.White);
            //whiteCat.Owner = peshoOwner;
            var anotherCat = new Cat(CatColor.Black);
            var yetAnotherCat = new Cat(CatColor.Brown);

            peshoOwner.AddCat(cat, "Dzhinks");
            peshoOwner.AddCat(anotherCat, "Silvestar");

            // this will cause Unhandled Exception: System.NullReferenceException: Object reference not set to an instance of an object. => Line 25 in Owner.cs
            Console.WriteLine(peshoOwner.AllCats);  //Dzhinks, Silvestar

            // print static property
            Console.WriteLine(Cat.NumberOfLegs);    //4

            // print the result from a static method WhatDoesTheCatSay()
            Console.WriteLine(Cat.WhatDoesTheCatSay()); //Mew!

            // invoke the static method PrintCat() in static class Printer
            Printer.PrintCat(cat);  //Dzhinks 0

            // changing cat's name, because it's reference data type 
            ChangeCatName(anotherCat);
            Console.WriteLine(anotherCat.Name); //Johny

        }
    }
}
