namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private const decimal ConvertedHeight = 0.10m;

        // Has too states – converted and normal. 
        // Initial state is normal.
        private bool isConverted = false;

        public ConvertibleChair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {

        }

        public bool IsConverted
        {
            get { return this.isConverted; }
        }

        public void Convert()
        {
            // States can be changed by converting the chair from one to another.
            //this.isConverted = !this.isConverted;
            // other way
            if (this.isConverted)
            {
                this.isConverted = false;
            }
            else
            {
                this.isConverted = true;
            }
        }

        public override decimal Height
        {
            get
            {
                //Converted state sets the height to 0.10m.
                //Normal state returns the height to the initial one.
                // single responsibility principle
                if (this.isConverted)
                {
                    return ConvertedHeight;
                }
                else
                {
                    return base.Height;
                }
            }
            protected set
            {
                base.Height = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}",
                this.IsConverted ? "Converted" : "Normal");
        }
    }
}