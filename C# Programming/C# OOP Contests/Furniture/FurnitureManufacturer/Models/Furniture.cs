namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture    // Ctrl + . => implement
    {
        private string model;  
        private decimal price;
        private decimal height;

        public virtual string Model  // make the properties virtual, so could be override if have to
        {
            get 
            { 
                return this.model; 
            }
            protected set   // by interface string Model { get; }
            {
                // validation => encapsulation and rules by requirement:
                // Model cannot be empty, null or with less than 3 symbols.
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be empty or null!");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Model cannot be with less than 3 symbols!");
                }

                this.model = value;
            }
        }        
        
        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            set   // by interface decimal Price { get; set; } => so the set must be public
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be less or equal to $0.00!");
                }

                this.price = value;
            }
        }

        public virtual decimal Height
        {
            get { return this.height; }
            protected set               // by interface decimal Height { get; }
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be less or equal to 0.00 m!");
                }

                this.height = value;
            }
        }

        // there is no validation and by interface its string Material { get; } => make automatic property:
        public virtual string Material 
        {
            get
            {
                return this.MaterialType.ToString();
            } 
        }
        
        protected MaterialType MaterialType { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}
