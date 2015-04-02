namespace Animals.Animals
{
    using System;

    public class Cat : IAnimal
    {
        public Cat(string name)
        {
            this.Name = name;                
        }

        public string Name { get; private set; }

        public string Speak()
        {
            return string.Format("{0} says Myau!", this.Name);
        }

        public string Purr()
        {
            return string.Format("{0} says Mrrr!", this.Name);
        }
    }
}