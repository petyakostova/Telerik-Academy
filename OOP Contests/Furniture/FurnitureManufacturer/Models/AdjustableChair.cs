namespace FurnitureManufacturer.Models
{    
    using System;
    using FurnitureManufacturer.Interfaces;

    public class AdjustableChair : Chair, IAdjustableChair
    {
        private string materialType;

        public AdjustableChair(string model, Models.MaterialType materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
        }

        public void SetHeight(decimal height)
        {
            this.Height = height;   // through the property, because we want to use the check in Furniture.cs
        }
    }
}
