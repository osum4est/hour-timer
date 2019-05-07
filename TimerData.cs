using System;

namespace HourTimer
{
    public class TimerData
    {
        public DateTime StartDate { get; set; }

        public int TimerLength { get; set; }

        public DateTime EndDate => StartDate.AddHours(TimerLength);

        // Checks if EndDate comes before Now
        public bool Completed => EndDate < DateTime.Now;
    }
}
