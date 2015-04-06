namespace WarMachines.Engine
{
    using WarMachines.Interfaces;
    using WarMachines.Machines;

    public class MachineFactory : IMachineFactory
    {
        public IPilot HirePilot(string name)
        {
            // Implement this method
            return new Pilot(name);
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            // TODO: Implement this method
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            // TODO: Implement this method
        }
    }
}
