namespace Animals.Animals
{
    using System;

    public class Dog : Animal, IAnimal
    {
        public Dog(string name, int age) 
            : base(age)
        {
            this.Name = name;
        }

        //public string Name { get; private set; }    => removed because of Animal.cs

        public override string Speak()
        {
            return string.Format(base.Speak() + " Bau!", this.Name);
        }

        public string CatchBone()
        {
            return string.Format(base.Speak() + " I catch the bone!", this.Name);
        }

        public override string ToString()
        {
            return "I'm a dog.";
        }
    }
}