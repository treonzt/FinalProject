using FinalProject_Group1.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Group1.Interfaces2
{
    // @author: Zach Treon
    public interface ITeamInfoContextDAO2
    {
        List<TeamInfo2> GetAllTeamInfos();
        TeamInfo2 GetTeamByID(int id);
        int? RemoveTeamById(int id);
        int? UpdateTeam(TeamInfo2 team);
        int? Add(TeamInfo2 team);
    }
}
