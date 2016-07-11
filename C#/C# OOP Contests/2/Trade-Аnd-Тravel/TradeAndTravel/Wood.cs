namespace TradeAndTravel
{
    public class Wood : Item
    {
        private const int InitialValue = 2;

        public Wood(string name, Location location = null)
            : base(name, Wood.InitialValue, ItemType.Wood, location)
        {
        }

        // from Item.cs
        public override void UpdateWithInteraction(string interaction)
        {
            if (interaction == "drop")
            {
                if (this.Value > 0)
                {
                    this.Value--;
                }
            }

            //base.UpdateWithInteraction(interaction); // there is no point to invoke the base, because it's empty
        }

    }
}