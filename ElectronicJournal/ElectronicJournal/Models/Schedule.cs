using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicJournal.Models
{
    public class Schedule
    {
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public ITime TimeAbsrtract { get; set; }

        public Schedule(DateTime openTime, DateTime closeTime)
        {
            OpenTime = openTime;
            CloseTime = closeTime;
        }

        
    }
}
