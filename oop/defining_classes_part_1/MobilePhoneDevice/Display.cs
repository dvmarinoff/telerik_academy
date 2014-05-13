namespace MobilePhoneDevice
{

    using System;
    using System.Collections.Generic;

    public class Display
    {
        private float size;
        private int numberOfColors;

        public float Size 
        {
            get { return size; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value!");
                }
                else
                {
                    this.size = value;
                }
            }
        }
        public int NumberOfColors 
        {
            get { return numberOfColors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value!");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }
        public Display()
        {

        }

        public Display(float displaySize, int dispalyNumberOfColors)
        {
            this.Size = displaySize;
            this.NumberOfColors = dispalyNumberOfColors;
        }
    }
}
