using FinalProject_Group1.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Group1.Interfaces3
{

    //author: Avery Ingram
    public class ITeamInfoContextDao3
    {
        public interface ITeamInfoContextDAO3
        {
            List<TeamInfo3> GetAllTeamInfos();
            TeamInfo3 GetTeamByID(int id);
            int? RemoveTeamById(int id);
            int? UpdateTeam(TeamInfo3 team);
            int? Add(TeamInfo3 team);
        }
    }
}
