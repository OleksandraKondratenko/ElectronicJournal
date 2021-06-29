using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicJournal.Models
{
    public struct IntervalsTime: ITime
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
