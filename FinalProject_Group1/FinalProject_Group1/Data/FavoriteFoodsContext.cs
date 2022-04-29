using FinalProject_Group1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Group1.Data
{
    public class FavoriteFoodsContext :DbContext
    {
        public FavoriteFoodsContext(DbContextOptions<FavoriteFoodsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            _ = builder.Entity<FavoriteFoods>().HasData(
                new FavoriteFoods { Id = 1, favBreakfast = "Biscuits and Gravy", favLunch = "Tacos, any kind!", favDinner = "Steak and Potatoes", favDessert = "Cheesecake" }
                );
        }

        public DbSet<FavoriteFoods> FavoriteFoods { get; set; }
    }
}
