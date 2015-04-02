namespace Animals.Animals
{
    using System;

    public abstract class Animal : IAnimal
    {
        // protected => all inheritors can use it
        public string Name { get; protected set; }

        // virtual method => can be changed from the inheritors
        public virtual string Speak()
        {
            return "{0} says";
            //throw new InvalidOperationException(); // other variant
        }
        
    }
}