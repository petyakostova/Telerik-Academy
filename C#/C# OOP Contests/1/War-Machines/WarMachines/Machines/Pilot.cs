namespace WarMachines.Machines
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Common;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        // must be the most abstract => IEnumerable, but:
        // IEnumerable gives foreach; doesn't give Add, Remove, Count etc.
        // ICollection gives all - Add, Remove, Count etc.
        // IList is the interface of the List - gives indexator, all methods to the collections
        private IList<IMachine> machines;

        // created in MachineFactory
        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Pilot name cannot be null!");

                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            // check object is it null
            Validator.CheckIfNull(machine, "Null machine cannot be added to pilot!"); 

            this.machines.Add(machine);
        }

        public string Report()
        {
            var sortedMachines =
                this.machines
                    .OrderBy(m => m.HealthPoints)   //using System.Linq;
                    .ThenBy(m => m.Name);
            // OrderBy and ThenBy return new collection and must be declared new variable to get the result

            var noMachineMaybe =
                this.machines.Count > 0
                ? this.machines.Count.ToString()
                : "no";

            var pluralMachinesMaybe =
                this.machines.Count == 1
                ? "machine"
                : "machines";

            var result = new StringBuilder();

            result.AppendLine(string.Format("{0} - {1} {2}", this.Name, noMachineMaybe, pluralMachinesMaybe));

            foreach (var machine in sortedMachines) // very important is to be sortedMachines, not machines
            {
                result.AppendLine(machine.ToString());  // very important is to be machine, not machines
            }

            return result.ToString().Trim();
        }
    }
}