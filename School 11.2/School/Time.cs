using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Time
    {
        private int hours,minutes,seconds;

        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public int Hours
        {
            get { if (hours >= 0 && hours < 23) Hours = hours; else hours = 0; return hours; }
            set { hours = value; }
        }
        public int Minutes
        {
            get { if (minutes >= 0 && minutes < 59) Minutes = minutes; else minutes = 0; return minutes; }
            set { minutes = value; }
        }
        public int Seconds
        {
            get { if (seconds >= 0 && seconds < 59) Seconds = seconds; else seconds = 0; return seconds; }
            set { seconds = value; }
        }
        public string TimeOutput()
        {
            return Hours+":"+Minutes+":"+Seconds;
        }
    }
}
