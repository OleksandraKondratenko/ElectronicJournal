using ElectronicJournal.Models;
using ElectronicJournal.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicJournal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : Controller
    {
        RoomService roomService;
        public RoomsController()
        {
            roomService = new RoomService();
        }
        [HttpGet]
        public async Task<List<Room>> GetAll ()
        {
            var myRooms = Task.Run(() => roomService.GetAll());
            List<Room> rooms = await myRooms;
            return rooms  ;
        }

        [HttpPost("something")]
        public async Task<bool> PostSomething(int something)
        {
            return something == 10;
        }
        

    }
}
