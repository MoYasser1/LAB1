using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Duration
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Duration(int hours, int minutes, int seconds)
        {
            this.hours = hours + minutes / 60 + seconds / 3600;
            this.minutes = (minutes + seconds / 60) % 60;
            this.seconds = seconds % 60;
        }

        public Duration(int totalSeconds)
        {
            hours = totalSeconds / 3600;
            minutes = (totalSeconds % 3600) / 60;
            seconds = totalSeconds % 60;
        }

        //public int Hours
        //{
        //    get { return hours; }
        //    set { hours = value; }
        //}
        public int Hours
        {
            get => hours;
            set => hours = value;
        }
        //public int Minutes
        //{
        //    get { return minutes; }
        //    set { minutes = value; }
        //}
        public int Minutes
        {
            get => minutes;
            set => minutes = value;
        }
        //public int Seconds
        //{
        //    get { return Seconds; }
        //    set { Seconds = value; }
        //}
        public int Seconds
        {
            get => seconds;
            set => seconds = value;
        }

        public string GetString()
        {
            return $"{(hours > 0 ? $"Hours: {hours}, " : "")}" +
                   $"{(minutes > 0 || hours > 0 ? $"Minutes: {minutes}, " : "")}" +
                   $"Seconds: {seconds}";
        }
    }
}
