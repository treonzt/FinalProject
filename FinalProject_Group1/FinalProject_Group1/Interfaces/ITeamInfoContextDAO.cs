using FinalProject_Group1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Group1.Interfaces
{
    // @author: Ishani Saxena
    public interface ITeamInfoContextDAO
    {
        List<TeamInfo> GetAllTeamInfos();
        TeamInfo GetTeamByID(int id);
        int? RemoveTeamById(int id);
        int? UpdateTeam(TeamInfo team);
        int? Add(TeamInfo team);
    }
}
