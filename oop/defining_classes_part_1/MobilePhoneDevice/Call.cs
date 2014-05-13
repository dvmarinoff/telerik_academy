namespace MobilePhoneDevice
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Call
    {
        //private DateTime date;
        //private DateTime time;
        //private uint dialedNumber;
        //private byte duration;

        private List<Call> callHistory;

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }
        //Automatic proprties(shorthand to field + property, when data validation is not "needed"):
        public byte Duration { get; set; }
        public string DialedNumber { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

        public Call(string dialedPhoneNumber, byte duration)
        {
            this.Date = DateTime.Now;
            this.DialedNumber = dialedPhoneNumber;
            this.Duration = duration;
        }

    }
}
