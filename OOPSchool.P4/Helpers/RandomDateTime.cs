using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSchool.P4.Helpers
{
    public class RandomDateTime
    {
        private readonly Random rand = new Random();
        public DateTime Next(DateTime start, DateTime end)
        {
            var range = (end - start).Days;
            return start
                .AddDays(rand.Next(range))
                .AddHours(rand.Next(0, 24))
                .AddMinutes(rand.Next(0, 60))
                .AddSeconds(rand.Next(0, 60));
        }
        public DateTime Next(DateTime)
    }
}
