using ElectronicJournal.Models;
using ElectronicJournal.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace ElectronicJournal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : Controller
    {
        private RoomService _roomService;

        public RoomsController()
        {
            _roomService = new RoomService();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var myRooms = Task.Run(() => _roomService.GetAll());
            List<Room> rooms = await myRooms;

            return Ok(rooms);
        }

        [HttpGet("byid")]
        public async Task<IActionResult> GetByID(int id)
        {
            if (id < 10)
            {
                var myRoom = Task.Run(() => _roomService.GetByID(id));
                var room = await myRoom;
                return Ok(room);
            }
            else
            {
                return Ok(StatusCode((int)HttpStatusCode.NotFound));
            }

        }

        [HttpPost]
        public async Task<IActionResult> Post(Room room)
        {
            var awaitResult = Task.Run(() => _roomService.Create(room));

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Room room)
        {
            Task.Run(() => _roomService.Update(room));

            return Ok();
        }

        //[HttpDelete]
        //public async void
    }
}
