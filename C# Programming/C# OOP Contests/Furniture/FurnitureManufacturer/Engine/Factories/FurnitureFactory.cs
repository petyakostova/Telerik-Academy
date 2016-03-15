namespace FurnitureManufacturer.Engine.Factories
{
    using System;

    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class FurnitureFactory : IFurnitureFactory
    {
        private const string Wooden = "wooden";
        private const string Leather = "leather";
        private const string Plastic = "plastic";
        private const string InvalidMaterialName = "Invalid material name: {0}";

        public ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
            // Implement this method
            //(Ctr+. => generate constructor in FurnitureManufacturer.Models.Table => F12 go there)
            return new Table(
                model,
                GetMaterialType(materialType),
                price,
                height,
                length,
                width);

        }

        public IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            // Implement this method
            //(Ctr+. => generate constructor in FurnitureManufacturer.Models.Chair => F12 go there)
            return new Chair(
                model,
                GetMaterialType(materialType),
                price,
                height,
                numberOfLegs);
        }

        public IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            // Implement this method
            //(Ctr+. => generate constructor in FurnitureManufacturer.Models.AdjustableChair => F12 go there)
            return new AdjustableChair(
                model,
                GetMaterialType(materialType),
                price,
                height,
                numberOfLegs);
        }

        public IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            // Implement this method
            //(Ctr+. => generate constructor in FurnitureManufacturer.Models.ConvertibleChair => F12 go there)
            return new ConvertibleChair(
                model,
                GetMaterialType(materialType),
                price,
                height,
                numberOfLegs);           
        }

        private MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Wooden:
                    return MaterialType.Wooden;
                case Leather:
                    return MaterialType.Leather;
                case Plastic:
                    return MaterialType.Plastic;
                default:
                    throw new ArgumentException(string.Format(InvalidMaterialName, material));
            }
        }
    }
}
