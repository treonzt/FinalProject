using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_Group1.Models
{
    public class TeamInfo
    {
        public int Id { get; set; }
        public string fullName { get; set; }
        public DateTime birthdate { get; set; }
        public string collegeProgram { get; set; }

        public string yearInProgram { get; set; }
    }
}
