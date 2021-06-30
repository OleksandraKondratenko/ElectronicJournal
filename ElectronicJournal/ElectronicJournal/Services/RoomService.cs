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
                new Room{ ID=2, Name = "Blue", Description="tatatat", OpenTime= new DateTime(2021,03,15), CloseTime = new DateTime(2021,03,16)},
                new Room{ ID=3, Name = "Yellow", Description="ltututut", OpenTime= new DateTime(2021,03,15), CloseTime = new DateTime(2021,03,16)}
            };
        }

        public List<Room> GetAll()
        {
            return _rooms.ToList<Room>();
        }

        public Room GetByID(int id)
        {
            return _rooms.FirstOrDefault(x => x.ID == id);
        }

        public bool Create(Room room)
        {
            bool result = false;

            try
            {
                _rooms.Add(room);
                result = true;

            }
            catch
            {

            }

            return result;
        }

        public void Update(Room room)
        {
            var currentRoom = _rooms.FirstOrDefault(x => x.ID == room.ID);
            currentRoom.Name = room.Name;
            currentRoom.Description = room.Description;
            currentRoom.OpenTime = room.OpenTime;
            currentRoom.CloseTime = room.CloseTime;
        }
    }
}