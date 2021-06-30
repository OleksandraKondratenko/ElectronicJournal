using ElectronicJournal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicJournal.Data
{
    public class DBInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();

            if (context.Rooms.Any())
            {
                return;
            }
            var rooms = new Room[]
            {
                new Room{Name = "Red", Description="Romantic", OpenTime = new DateTime(2021,06,28), CloseTime= new DateTime(2021,06,29) },
                new Room{Name = "Blue", Description="Romantic", OpenTime = DateTime.Parse("2008-09-01"), CloseTime= DateTime.Parse("2008-09-01") }
            };

            foreach (var room in rooms)
            {
                context.Rooms.Add(room);
            }

            context.SaveChanges();
        }
    }
}
