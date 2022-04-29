using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_Group1.Models
{
    public class FavoriteFoods
    {
        public int Id { get; set; }
        public string favBreakfast { get; set; }
        public string favLunch { get; set; }
        public string favDinner { get; set; }

        public string favDessert { get; set; }
    }
}
