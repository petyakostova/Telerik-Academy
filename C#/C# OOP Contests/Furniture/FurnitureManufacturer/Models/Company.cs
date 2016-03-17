namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;   
    using FurnitureManufacturer.Interfaces;     

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        // wont' use this constructor, so could be deleted
        //public Company()
        //{
        //    // initialize the field furnitures
        //    // ICollection is interface so can't create an instance, so we use List 
        //    this.furnitures = new List<IFurniture>();
        //}

        // constructor for CompanyFactory.cs
        public Company(string name, string registrationNumber)
        {
            this.furnitures = new List<IFurniture>();
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                // Name cannot be empty, null or with less than 5 symbols
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty or null!");
                }
                if (value.Length < 5)
                {
                    throw new ArgumentException("Name cannot be with less than 5 symbols!");
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            protected set
            {
                // Registration number must be exactly 10 symbols and must contain only digits.
                if (value == null || value.Length != 10)
                // need null check otherwise value.Length will cause an NoReferenceException
                {
                    throw new ArgumentException("Registration number must be exactly 10 symbols!");
                }

                if (!this.ContainsOnlyDigits(value))
                {
                    throw new ArgumentException("Registration number must contain only digits!");
                }

                this.registrationNumber = value;
            }
        }

        public System.Collections.Generic.ICollection<IFurniture> Furnitures    // needed field
        {
            get { return this.furnitures; }
        }

        public void Add(IFurniture furniture)
        {
            // Adding duplicate furniture is allowed.
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            // Removing furniture removes the first occurance. If such is not found, nothing happens.
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            /*
            // Finding furniture by model gets the first occurance.             
            foreach (var furnitureInCollection in this.furnitures)
            {
                if (string.Compare(
                    furnitureInCollection.Model,
                    model,
                    true) == 0)   // Searching is case insensitive.
                {
                    return furnitureInCollection;
                }
            }

            // If such is not found, return null.
            return null;
             */

            return this.furnitures.FirstOrDefault(f => 
                f.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            var sb = new StringBuilder();   // using System.Text; 
            sb.AppendLine(string.Format(
                "{0} - {1} - {2} {3}",
                    this.Name,
                    this.RegistrationNumber,
                    this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                    this.Furnitures.Count != 1 ? "furnitures" : "furniture"
                ));
            
            // polymorphism need
            // every different class of furniture has different behavior of their visualization 
            /* There are two solutions:
             * create a polymorphic method GetInfo and every class to implement it or
             * use ToString() method, which every object has, and override it in every class 
            */

            // foreach furnitures
            foreach (var furniture in 
                this.furnitures
                    .OrderBy(f => f.Price)
                    .ThenBy(f => f.Model))
            {
                sb.AppendLine(furniture.ToString());    // polymorphism
            }

            // to don't have unneccesary line after every ToString:
            // first way
            //sb.Remove(sb.Length - 1, 1);    // Remove(startIndex, length)
            //return sb.ToString();
            // second way
            return sb.ToString().TrimEnd(); // removes the unneccesary intervals in the end
            // return sb.ToString().TrimEnd('\n', '\r'); // removes the unneccesary intervals in the end
        }

        // method for check if registration number contains only digits
        private bool ContainsOnlyDigits(string str)
        {
            foreach (var ch in str)
            {
                // if (ch > '0' || ch < '9')
                if (char.IsDigit(ch))
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
