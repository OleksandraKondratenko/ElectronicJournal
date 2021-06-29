using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicJournal.Models
{
    public class Room
    {
        public int ID { get; set; }
        public IntervalsTime WorkHours { get; set; }
        public DateTime AllBookedTime { get; private set; }
        public DateTime AllFreeTime { get; private set; }


    }
}
