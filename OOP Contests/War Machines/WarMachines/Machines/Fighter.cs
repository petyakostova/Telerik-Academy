namespace WarMachines.Machines
{
    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter, IMachine
    {
        private const int InitialHealthPoints = 200;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }
    }
}
