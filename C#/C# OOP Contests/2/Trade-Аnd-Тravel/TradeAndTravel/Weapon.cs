using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class Weapon : Item
    {
        private const int InitialValue = 10;

        public Weapon(string name, Location location = null)
            : base(name, InitialValue, ItemType.Weapon, location)
        {
        }

    }
}