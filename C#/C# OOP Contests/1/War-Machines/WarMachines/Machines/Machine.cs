namespace WarMachines.Machines
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

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
            this.targets = new List<string>(); // must be instanced
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

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("- {0}", this.Name));

            // GetType().Name => get the type and give the name (like string)
            result.AppendLine(string.Format(" *Type: {0}", this.GetType().Name)); // The name of the class "Tank"/"Fighter"
            result.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            result.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            result.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));

            // in this case it's better to use targets instead of Targets, so don't foreach once more
            var targetsAsString = 
                this.targets.Count > 0
                    ? string.Join(", ", this.targets)
                    : "None";

            result.AppendLine(string.Format(" *Targets: {0}", targetsAsString));

            return result.ToString();
        }
    }
}