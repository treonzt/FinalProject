using FinalProject_Group1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Group1.Interfaces
{
    public interface ITeamInfoContextDAO
    {
        List<TeamInfo> GetAllTeamInfos();
    }
}
