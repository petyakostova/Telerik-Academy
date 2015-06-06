namespace Bunnies
{
    using Animals;
    using System;
    //using System.Collections.Generic;

    public class Bunny : Animal  // we must set "public" Access Modifier (by default it's internal)
    // Bunny inherits Animal
    {
        private static int NumberOfLegs = 4;

        // constants               

        private const int InitialHealth = 100;  // constant (magic number) (can be string, Bunny...)
        private const int InitialCarrots = 0;

        // fields

        //private readonly string name;   // field for rabbit's name, which is readonly => removed because of Animal
        private ColorType color;           // field
        private ulong carrotsCount;     // field            
        //private ulong carrotsCount = 0; // this is wrong => must be in the constructor
        //private int health;   => better automatic property  => public int Health { get; set; }     


        // if we create list => it must be initialized in the constructor => line 42
        //List<int> something;


        // constructors

        //public Bunny()  // empty constructor - if we need it - rarely => Bunny peshoBunny = new Bunny();
        //{

        //} 

        public Bunny(string bunnyName)    // the name of the constructor must be the same like the class name
        {
            this.Name = bunnyName;
            this.Health = InitialHealth;    // set initial value            
            this.carrotsCount = InitialCarrots;
            //something = new List<int>();
            this.isRetired = false;
        }

        //// constructor for rabbit with name and color
        //public Bunny(string bunnyName, string playerColor)
        //{
        //    this.name = bunnyName;
        //    this.health = InitialHealth;              
        //    this.carrotsCount = InitialCarrots;
        //    this.color = playerColor;
        //}

        // DRY => Don't repeat yourself => so:
        // reuse (use again) the constructor:
        public Bunny(string bunnyName, ColorType playerColor)
            : this(bunnyName)
        {
            this.color = playerColor;
        }


        //public string GetName()
        //{
        //    return this.name;
        //}
        //public void SetName(string newName)
        //{
        //    this.name = newName;  // won't work because it's read only
        //}

        // properties

        //it's not ok to make methods for everything, so we use properties:      
        //public string Name    // removed because of Animal
        //{
        //    get
        //    {
        //        return this.name;
        //    }
        //}

        public ColorType Color
        {
            get
            {
                return this.color;
            }
            set
            {
                //// after adding enumeration there is no need from data validation
                //if (value != "Blue" && value != "Red")  // validating 
                //{
                //    throw new ArgumentException("Color must be \"Blue\" or \"Red\"");   // using System;
                //}

                this.color = value;  // set data
            }
        }

        //// property without validation
        //public int Health
        //{
        //    get
        //    {
        //        return this.health;
        //    }
        //    set
        //    {
        //        this.health = value;
        //    }
        //}

        // it's better to use automatic property (line 23)
        // public int Health { get; set; }  // removed because of Animal
        //public int Health { get; private set; }   

        public bool isRetired { get; private set; }


        // methods

        //// method for color changing
        //public void ChangeColor(string newColor)
        //{
        //    this.color = newColor;
        //}

        // method for adding carrots and return the new count
        public ulong AddCarrots(uint carrots)
        {
            this.carrotsCount += carrots;
            return this.carrotsCount;
        }

        public void Retire()
        {
            if (this.Health < 0)
            {
                this.isRetired = true;
            }
        }


        //// inner types => the class has other class
        //// it's not quality code, but sometimes needed
        //public class Carrot
        //{

        //}


        public int Damage   // dynamic property
        {
            get
            {
                if (this.Health < 0)
                {
                    return InitialHealth;
                }

                int damage = InitialHealth - this.Health;

                return damage;
            }
        }

        public override string ToString()
        {
            return this.Name + " " + this.Health;
        }
    }
}