namespace Animals.Animals
{
    using System;

    public abstract class Animal : IAnimal
    {
        private int age;

        public Animal(int age)
        {
            this.Age = age;
        }

        // protected => all inheritors can use it
        public string Name { get; protected set; }

        // this logic is for all animals and stands hier instead of in all animals
        public int Age 
        { 
            get 
            {
                return this.age;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.age = value;
            }
        }
                
        // virtual method => can be changed from the inheritors
        public virtual string Speak()
        {
            return "{0} says";
            //throw new InvalidOperationException(); // other variant
        }
        
    }
}