using FinalProject_Group1.Interfaces;
using FinalProject_Group1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Group1.Data
{
    public class TeamInfoContextDAO : ITeamInfoContextDAO
    {
        private TeamInfoContext _context;
        public TeamInfoContextDAO(TeamInfoContext context)
        {
            _context = context;
        }

        public List<TeamInfo> GetAllTeamInfos()
        {
            return _context.TeamInfo.ToList();
        }
    }
}
