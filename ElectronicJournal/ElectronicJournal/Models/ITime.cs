using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicJournal.Models
{
    public interface ITime
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
