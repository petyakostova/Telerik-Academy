namespace WarMachines.Machines
{
    using System.Collections;
    using System.Collections.Generic;

    using WarMachines.Common;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;           // using WarMachines.Interfaces;
        private IList<string> targets;  // using System.Collections;

        // abstract class Mashine => cannot instance => only inheritors will invoke it => protected constructor:
        protected Machine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>(); 
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Machine name cannot be null!");

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                Validator.CheckIfNull(value, "Pilot cannot be null!");

                this.pilot = value;
            }
        }

        // health points comes from nowhere => must add it to the constructor
        public double HealthPoints { get; set; }

        // no validation => automatic property
        public double AttackPoints { get; protected set; }

        // no validation => automatic property
        public double DefensePoints { get; protected set; }

        // needed List => new field
        // then must instance it in the constructor
        public IList<string> Targets
        {
            //get { return this.targets; } => this is not ok => must be encapsulated

            get { return new List<string>(this.targets); }
        }

        public void Attack(string target)
        {
            Validator.CheckIfStringIsNullOrEmpty(target);

            this.targets.Add(target);
        }
    }
}
