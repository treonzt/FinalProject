using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_Group1.Models2
{
    public class TeamInfo2
    {
        public int Id { get; set; }
        public string fullName { get; set; }
        public string favoriteColor { get; set; }
        public string favoriteAnimal { get; set; }

        public string favoriteDrink { get; set; }
    }
}
