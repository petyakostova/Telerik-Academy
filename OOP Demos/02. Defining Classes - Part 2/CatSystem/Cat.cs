namespace CatSystem
{
    public class Cat
    {
        // static property
        public static int NumberOfLegs
        {
            get
            {
                return 4;
            }
        }

        // constructor
        public Cat(CatColor color)
        {
            this.Color = color;
        }

        // properties
        public string Name { get; set; }

        public int Аgе { get; private set; }

        public Owner Owner { get; set; }

        public CatColor Color { get; private set; }

        // static method 
        // Always return the most primitive data type - don't print it on the console!
        public static string WhatDoesTheCatSay()
        {
            return "Mew!";
        }
    }
}
