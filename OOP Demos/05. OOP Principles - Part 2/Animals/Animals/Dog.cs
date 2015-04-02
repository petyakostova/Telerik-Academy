namespace Animals.Animals
{
    using System;

    public class Dog : IAnimal
    {
        public Dog(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public string Speak()
        {
            return string.Format("{0} says Bau!", this.Name);
        }

        public string CatchBone()
        {
            return string.Format("{0} says I catch the bone!", this.Name);
        }
    }
}