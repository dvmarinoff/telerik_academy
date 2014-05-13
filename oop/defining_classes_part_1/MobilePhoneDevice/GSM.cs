namespace MobilePhoneDevice
{

    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        //Fields:
        private string model;
        private string manufacturer;
        private string owner;
        private decimal price;

        private static GSM iphoneS4;

        private List<Call> callHistory { get; set; }

        public Battery battery = new Battery("someModel", 2.0f, 4.0f, Battery.BatteryType.LiIon);
        public Display displey = new Display(5.6f, 256);



        //Properties:
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Owner { get; set; }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("This isn't BDZ ;)");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public static GSM IPhoneS4
        {
            get
            {
                return iphoneS4;
            }
        }

        //Constructors (chained for code re-use) with 2, 3 and 4 parameters:
        public GSM(string gsmModel, string gsmManufecturer)
        {
            this.Model = gsmModel;
            this.Manufacturer = gsmManufecturer;
        }

        public GSM(string gsmOwner, string gsmModel, string gsmManufecturer)
            : this(gsmModel, gsmManufecturer)
        {
            this.Owner = gsmOwner;
        }
        public GSM(string gsmOwner, decimal gsmPrice, string gsmModel, string gsmManufecturer)
            : this(gsmModel, gsmManufecturer, gsmOwner)
        {

            if (Price < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input");
            }
            else
            {
                this.price = Price;
            }
        }

        //Override ToString method:       
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Model: " + this.Model);
            sb.AppendLine("Manufacturer: " + this.Manufacturer);
            sb.AppendLine("Price: " + this.Price + " " + "EUR");
            sb.AppendLine("Owner: " + this.Owner);
            sb.AppendLine("Battery model: " + this.battery.Model);
            sb.AppendLine("Battery type: " + this.battery.Type);
            sb.AppendLine("Hours idle: " + this.battery.Idle);
            sb.AppendLine("Hours talk: " + this.battery.Talk);
            sb.AppendLine("Display size: " + this.displey.Size + "\"");
            sb.AppendLine("Display colors: " + this.displey.NumberOfColors);

            return sb.ToString();
        }

        //Call Methods:
        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CalculeteTotolPrice(decimal pricePerMinute)
        {
            decimal totalPrice = 0;
            foreach (var call in callHistory)
            {
                totalPrice += call.Duration * pricePerMinute / 60;
            }
            return totalPrice;
        }
    }
}
