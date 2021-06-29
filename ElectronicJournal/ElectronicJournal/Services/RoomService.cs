using ElectronicJournal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicJournal.Services
{
    public class RoomService
    {
        private ICollection<Room> _rooms;
        public RoomService()
        {
            _rooms = new List<Room>
            {
                new Room{ ID=1, Name = "Red", Description="lalalal", OpenTime= new DateTime(2021,03,15), CloseTime = new DateTime(2021,03,16)},
                new Room{ ID=1, Name = "Blue", Description="tatatat", OpenTime= new DateTime(2021,03,15), CloseTime = new DateTime(2021,03,16)},
                new Room{ ID=1, Name = "Yellow", Description="ltututut", OpenTime= new DateTime(2021,03,15), CloseTime = new DateTime(2021,03,16)}
            };
        }
        public List<Room> GetAll()
        {
            return _rooms.ToList<Room>();
        }
    }
}
