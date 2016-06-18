namespace MobilePhoneDevice
{
    using System;
    using System.Text;

    /* 8. Create a class Call to hold a call performed through a GSM.
       It should contain date, time, dialled phone number and duration (in seconds). */

    class Call
    {
        private string phoneNumber;
        private ulong duaration;

        //the only constructor - phonenumber and duaration needed
        public Call(string phonenumber, ulong duaration)
        {
            this.DateTime = DateTime.Now;
            this.PhoneNumber = phonenumber;
            this.Duaration = duaration;
        }

        // automatic property because we don't need validation
        public DateTime DateTime { get; private set; }        

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phonenumber can not be null or empty!");
                }

                if ((value.Length != 10 && value.Length != 13) || (value[0] != '0' && value[0] != '+'))
                {
                    throw new ArgumentException("Phonenumber must be in format +359xxxxxxxxx OR 0xxxxxxxxx !");
                }

                this.phoneNumber = value;
            }
        }

        public ulong Duaration
        {
            get
            {
                return this.duaration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Duaration can not be a negative number!");
                }

                this.duaration = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringCreator = new StringBuilder();
            stringCreator.AppendFormat("{0} : Duaration - {1} , made on {2}", this.PhoneNumber, this.Duaration, this.DateTime);
            stringCreator.AppendLine();
            return stringCreator.ToString();
        }
    }
}