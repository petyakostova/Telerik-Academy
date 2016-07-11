namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;    

    public class Table : Furniture, ITable
    {   
        // constructor for FurnitureFactory.cs
        public Table(string model, MaterialType materialType, decimal price, decimal height, decimal length, decimal width)
        {
            this.Model = model;
            // MaterialType is enumeration; there is method GetMaterialType(string material) in FurnitureFactory.cs;
            // there is no validation for materialType by requirement
            // every furniture has material type, so we put it in the Furniture.cs
            this.MaterialType = materialType;   // the property is in Furniture.cs
            this.Price = price;
            this.Height = height;
            this.Length = length;
            this.Width = width;
        }        

        // for length and width there is no validation
        public decimal Length { get; private set; }

        public decimal Width { get; private set; }
       
        public decimal Area
        {
            get { return this.Length * this.Width; }
            set
            {
                this.Area = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(
                ", Length: {0}, Width: {1}, Area: {2}", this.Length, this.Width, this.Area) ;
        }

    }
}