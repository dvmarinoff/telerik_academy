﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class EventTest
    {
        static void Main(string[] args)
        {
            Timer newTimer = new Timer(1, 10);
            newTimer.TimeChanged += Timer_TimeChanged;
            newTimer.Run();
        }

        public static void Timer_TimeChanged(object sender, TimeChangedEventArgs e)
        {
            Console.WriteLine("Time has changed " + e.TickCount);
        }
    }
}
