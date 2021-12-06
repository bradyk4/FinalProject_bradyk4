using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject_wsad_bradyk4.Models
{
    public class MedalContext : DbContext
    {
        public MedalContext(DbContextOptions<MedalContext> options) : base(options)
        { }
        public DbSet<Medal> Medals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medal>().HasData(
                new Medal
                {
                    MedalId = 1,
                    Event = "US University Nationals",
                    Name = "Jordan Burroughs",
                    Year = 2007,
                    Place = 2
                }, 
                new Medal
                {
                    MedalId = 2,
                    Event = "US Open",
                    Name = "Jordan Burroughs",
                    Year = 2011,
                    Place = 1
                }, 
                new Medal
                {
                    MedalId = 3,
                    Event = "World Championships",
                    Name = "Jordan Burroughs",
                    Year = 2021,
                    Place = 1
                });
        }
    }
}
