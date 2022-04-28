using FinalProject_Group1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Group1.Data
{
    public class TeamInfoContext :DbContext
    {
        public TeamInfoContext(DbContextOptions<TeamInfoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamInfo>().HasData(
                new TeamInfo { Id = 1, fullName = "Ishani Saxena", collegeProgram = "Cybersecurity and Software Development", yearInProgram = "sophomore", birthdate = new DateTime(2002, 6, 1) }
                );
        }

        public DbSet<TeamInfo> TeamInfo { get; set; }
    }
}
