using FinalProject_Group1.Models;
using FinalProject_Group1.Models3;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Group1.Data
{
        //author: Avery Ingram
        public class TeamInfoContext3 : DbContext
        {
            public TeamInfoContext3(DbContextOptions<TeamInfoContext3> options) : base(options) { }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                builder.Entity<TeamInfo3>().HasData(
                    new TeamInfo3 { Id = 1, fullName = "Avery Ingram", favoriteSport = "Basketball", favoriteTeam = "The Heat", favoritePlayer = "Lebron" }
                    );
            }

            public DbSet<TeamInfo3> TeamInfo3 { get; set; }
        }
}
