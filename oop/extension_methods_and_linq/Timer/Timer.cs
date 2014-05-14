namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;

    public delegate void TimerEvent();
    public class Timer
    {
        private int count;
        private int interval;
        private TimerEvent tE;
        private int ticks;


        public Timer(int count, int interval, TimerEvent TE)
        {
            this.Count = count;
            this.Interval = interval;
            this.tE = TE;
            this.ticks = 0;
        }

        public Timer(int interval, TimerEvent TE)
            : this(int.MaxValue, interval, TE) { }

        public Timer(TimerEvent TE)
            : this(int.MaxValue, 1, TE) { }

        public int Interval
        {
            get
            {
                return this.interval;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Interval must be > 0 !");
                }
                this.interval = value * 1000;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Count must be > 0 !");
                }
                this.count = value;
            }
        }

        public void Run()
        {
            while (ticks < this.count)
            {
                Thread.Sleep(this.Interval);
                ticks++;
                tE();
            }
        }
    }
}
