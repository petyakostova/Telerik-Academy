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
            // Implement this method
            return new Tank(name, attackPoints, defensePoints);
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            // TODO: Implement this method
            return new Fighter(name, attackPoints, defensePoints, stealthMode);
        }
    }
}
