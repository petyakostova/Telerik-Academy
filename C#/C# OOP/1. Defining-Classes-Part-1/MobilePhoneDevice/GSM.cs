namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    // 1. class that holds information about a mobile phone device: model, manufacturer, price, owner
    public class GSM
    {
        // 6. Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        // static field for iPhone4S
        private static readonly GSM iPhone4S = new GSM("IPhone 4S", "Apple", 1300.00m, "Telenor",
                                                        new Battery("Apple", 8, 200, Battery.Type.LiPo),
                                                        new Display(960, 640, 16000000));

        // constants
        //private constant callPrice
        private const decimal CallPricePerSecond = 0.37m;
        //private constants instead of null values..
        private const decimal DefaultPrice = 1800;
        private const string DefaultOwner = "JCorp";

        // fields
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private List<Call> CallHistory;
        /* 9. Add a property CallHistory in the GSM class to hold a list of the performed calls.
           Try to use the system class List<Call>. */

        // constructors        
        /* default constructor with only model and manufacturer
           2. model and manufacturer are mandatory (the others are optional) */
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, DefaultPrice, DefaultOwner, new Battery(), new Display()) 
        { 

        }

        //constructor with full arguments
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }

        // properties
        public string Model
        {
            get 
            { 
                return this.model; 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model can not be null or empty.");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get 
            { 
                return this.manufacturer; 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer can not be null or empty.");
                }

                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get 
            { 
                return this.price; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can not be a negative number.");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get 
            { 
                return this.owner; 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Owner can not be null or empty.");
                }

                this.owner = value;
            }
        }

        public Battery Battery { get; set; } // data validated in Battery class  
              
        public Display Display { get; set; } // data validated in Battery class 
                
        // 6. IPhone4S property
        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        // methods

        // 4. Add a method in the GSM class for displaying all information about it. Try to override ToString().
        public override string ToString()
        {
            StringBuilder stringCreator = new StringBuilder();
            stringCreator.Append("GSM Specifications:");
            stringCreator.Append(" ");
            stringCreator.AppendLine(new string('-', 90));
            stringCreator.AppendFormat("GSM Model - {0}", this.model);
            stringCreator.AppendLine();
            stringCreator.AppendFormat("GSM Manufacturer - {0}", this.manufacturer);
            stringCreator.AppendLine();
            stringCreator.AppendFormat("GSM Price - {0}", this.price);
            stringCreator.AppendLine();
            stringCreator.AppendFormat("GSM Owner - {0}", this.owner);
            stringCreator.AppendLine();
            stringCreator.AppendFormat("GSM Battery Specifications : Model - {1} , Type - {0} , talk time - {2} , idle time - {3}"
                          , this.Battery.BatteryType, this.Battery.Model, this.Battery.HoursTalk, this.Battery.HoursIdle);
            stringCreator.AppendLine();
            stringCreator.AppendFormat("GSM Display Specifications : Height - {0} , Width - {1} , Number of Colors - {2}",
                            this.Display.Height, this.Display.Width, this.Display.NumberOfColors);
            stringCreator.AppendLine();
            stringCreator.AppendLine(new string('-', 110));

            return stringCreator.ToString();
        }

        /* Add methods in the GSM class for adding and deleting calls from the calls history.
           Add a method to clear the call history. */

        //add call method (takes number as a string and duaration - dateTime is always NOW)
        public void AddCall(string currPhoneNumber, ulong currDuaration)
        {
            this.CallHistory.Add(new Call(currPhoneNumber, currDuaration));
        }

        //remove call - takes a position from the ShowCallHistoryMethod - starts count from 1 not 0 for more user friendly interface
        public void DeleteCall(int position)
        {
            if ((this.CallHistory.Count <= position - 1) || (position - 1 < 0))
            {
                throw new ApplicationException("Such call history log does not exist!");
            }
            this.CallHistory.RemoveAt(position - 1);
        }

        //adds an index so users can choose which call to delete
        public void ShowCallHistory()
        {
            Console.WriteLine("Current call history:");
            int indexer = 1;
            foreach (var call in this.CallHistory)
            {
                Console.Write(indexer++);
                Console.Write(" ---> ");
                Console.WriteLine(call.ToString());
            }
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        /* Add a method that calculates the total price of the calls in the call history.
           Assume the price per minute is fixed and is provided as a parameter. */
        public decimal TotalCallPrice()
        {
            ulong allDuaration = 0;

            foreach (var call in this.CallHistory)
            {
                allDuaration += call.Duaration;
            }

            return allDuaration * CallPricePerSecond;
        }
    }
}
