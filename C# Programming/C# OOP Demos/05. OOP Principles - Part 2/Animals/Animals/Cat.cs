namespace Animals.Animals
{
    using System;

    public class Cat : Animal, IAnimal
    {
        public Cat(string name, int age)
            : base(age)
        {
            this.Name = name;                
        }

        // string Name { get; private set; }   => removed because of Animal.cs

        public override string Speak()
        {
            // base.Speak() invokes the method Speak() from the base class
            return string.Format(base.Speak() + " Myau!", this.Name);
        }

        public string Purr()
        {
            return string.Format(base.Speak() + " Mrrr!", this.Name);
        }
    }
}