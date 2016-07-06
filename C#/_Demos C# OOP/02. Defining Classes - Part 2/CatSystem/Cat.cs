namespace CatSystem
{
    using System;

    public class Cat : Animal
    {
        // constructor
        public Cat(CatColor color)
        {
            this.Color = color;
        }

        // static property
        public static int NumberOfLegs
        {
            get
            {
                return 4;
            }
        }

        // properties
        //public string Name { get; set; }  //removed because of : Animal; the cat already have a Name

        public int Аgе { get; private set; }

        public Owner Owner { get; set; }

        public CatColor Color { get; private set; }

        public Gender Gender { get; set; } // hack the gender set => to set the cats for the +

        // static method 
        // Always return the most primitive data type - don't print it on the console!
        public static string WhatDoesTheCatSay()
        {
            return "Mew!";
        }

        // define the operator +
        public static Cat operator +(Cat first, Cat second)
        {
            if (first.Gender == Gender.Male && second.Gender == Gender.Female)
            {
                if (first.Color == second.Color)
                {
                    return new Cat(first.Color);
                }

                return new Cat(CatColor.Mixed);
            }

            throw new ArgumentException();
        }

        public static bool operator true(Cat cat) // must implement operator false too
        {
            if (cat.Color == CatColor.White)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator false(Cat cat) 
        {
            if (cat.Color == CatColor.White)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void GenerateGender()
        {
            // random gender
            var random = new Random();
            var genderIndex = random.Next(0, 2);
            this.Gender = (Gender)genderIndex;
        }

    }
}