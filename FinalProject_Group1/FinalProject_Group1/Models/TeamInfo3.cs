using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_Group1.Models3
{

    //author: Avery ingram
    public class TeamInfo3
    {
        [Key]
        public int Id { get; set; }
        public string fullName { get; set; }
        public string favoriteSport { get; set; }
        public string favoriteTeam { get; set; }

        public string favoritePlayer { get; set; }
    }
}
