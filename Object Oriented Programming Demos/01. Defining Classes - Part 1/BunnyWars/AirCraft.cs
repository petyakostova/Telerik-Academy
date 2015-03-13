namespace Bunnies
{
    public class AirCraft
    {
        //public static int Speed()
        //{
        //    return 100;
        //}

        public int Id { get; set; }     // automatic property

        public string Name { get; set; }

        public int Damage { get; set; }
        
        public Bunny Pilot { get; private set; }

        public AirCraft(Bunny bunny, int damage)    // constructor
        {
            this.Pilot = bunny;
            this.Damage = damage;
        }

        public void Attack(AirCraft target)     // method
        {
            target.Pilot.Health -= this.Damage;
        }
    }
}
