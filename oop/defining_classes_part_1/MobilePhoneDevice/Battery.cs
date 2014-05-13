namespace MobilePhoneDevice
{

    using System;
    using System.Collections.Generic;

    public class Battery
    {
        public enum BatteryType
        {
            LiIon, NiMH, NiCd
        }

        //Fields (some of these are replaced by the automatic properties, 
        //but I'll leave them as they are considering readability):
        private string model;
        private float idle;
        private float talk;
        private BatteryType type;

        //Properties:
        public string Model { get; set; }
        public float Idle
        {
            get { return this.idle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value!");
                }
                else
                {
                    this.idle = value;
                }
            }
        }
        public float Talk
        {
            get { return this.talk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value!");
                }
                else
                {
                    this.talk = value;
                }
            }
                    }
        public BatteryType Type { get; set; }

        //Constructors:
        public Battery()
        {

        }

        public Battery(string batteryModel, float batteryTimeIdle, float batteryTimeTalk, BatteryType bt)
        {
            this.Model = batteryModel;

            if (batteryTimeIdle < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.Idle = batteryTimeIdle;
            }

            if (batteryTimeTalk < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.Talk = batteryTimeTalk;
            }

            this.Type = bt;
        }
    }
}
