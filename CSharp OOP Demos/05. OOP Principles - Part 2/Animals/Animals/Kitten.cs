namespace Animals.Animals
{
    public class Kitten : Cat, IAnimal
    {
        public Kitten(string name, int age) 
            : base(name, age)
        {
           
        }

        // new => hiding virtual method Speak()
        public new string Speak()
        {
            return "Miyau";
        }
    }
}
