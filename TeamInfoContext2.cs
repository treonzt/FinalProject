using FinalProject_Group1.Models2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Group1.Data2
{
    public class TeamInfoContext2 : DbContext
    {
        public TeamInfoContext2(DbContextOptions<TeamInfoContext2> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamInfo2>().HasData(
                new TeamInfo2 { Id = 1, fullName = "Zach Treon", favoriteColor = "Green", favoriteAnimal = "Parakeet", favoriteDrink = "Root Beer" }
                );
        }

        public DbSet<TeamInfo2> TeamInfo2 { get; set; }
    }
}
