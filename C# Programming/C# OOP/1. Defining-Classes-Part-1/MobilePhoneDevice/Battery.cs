namespace MobilePhoneDevice
{
    using System;

    // class that holds information about battery characteristics: model, hours idle and hours talk
    public class Battery
    {
        // constants (instead of null values)
        private const string DefaultModel = "UnknownModel";
        private const uint DefaultHoursIdle = 200;
        private const uint DefaultHoursTalk = 100;        
        private const Type DefaultBatteryType = Type.AlienTech;

        // fields
        private string model;
        private uint hoursIdle;
        private uint hoursTalk;        
        private Type batteryType;

        // enumumeration for Battery Types - not in a seperate class because only this class uses it
        public enum Type
        {
            LiIon, 
            NiMH, 
            NiCd, 
            LiPo, 
            AlienTech
        }

        // constructors
        public Battery()
            : this(DefaultModel, DefaultHoursIdle, DefaultHoursTalk, DefaultBatteryType) 
        { 

        }

        public Battery(string model, uint hoursIdle, uint hoursTalk, Type batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;            
            this.BatteryType = batteryType;
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
                    throw new ArgumentException("The battery model can not be null or emtpy.");
                }
                this.model = value;
            }
        }

        public uint HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idle hours must be a possitive number.");
                }
                this.hoursIdle = value;
            }
        }

        public uint HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hours of talk time must be a possitive number.");
                }
                this.hoursTalk = value;
            }
        }

        public Type BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }
    
    }
}