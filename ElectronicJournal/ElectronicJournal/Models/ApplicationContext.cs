using Microsoft.EntityFrameworkCore;
using System;

namespace ElectronicJournal.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Room> Rooms { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().ToTable("Room");
        }
    }
}
