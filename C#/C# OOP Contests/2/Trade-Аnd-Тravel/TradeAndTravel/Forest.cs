using System;

namespace TradeAndTravel
{
    public class Forest : Location, IGatheringLocation
    {
        public Forest(string name)
            : base(name, LocationType.Forest)
        {
        }

        public ItemType GatheredType
        {
            get { return ItemType.Wood; }
        }

        // A Person can gather from a forest only if he has a Weapon in his inventory
        public ItemType RequiredItem
        {
            get { return ItemType.Weapon; }
        }

        public Item ProduceItem(string name)
        {
            return new Wood(name);
        }

    }
}