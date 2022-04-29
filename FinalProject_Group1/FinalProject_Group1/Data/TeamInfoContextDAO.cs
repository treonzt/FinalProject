using FinalProject_Group1.Interfaces;
using FinalProject_Group1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Group1.Data
{
    // @author: Ishani Saxena
    public class TeamInfoContextDAO : ITeamInfoContextDAO
    {
        private TeamInfoContext _context;
        // @author: Ishani Saxena
        public TeamInfoContextDAO(TeamInfoContext context)
        {
            _context = context;
        }

        // @author: Ishani Saxena
        public List<TeamInfo> GetAllTeamInfos()
        {
            return _context.TeamInfo.ToList();
        }
        
        // @author: Ishani Saxena
        public TeamInfo GetTeamByID(int id)
        {
            return _context.TeamInfo.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        // @author: Ishani Saxena
        public int? RemoveTeamById(int id)
        {
            var team = this.GetTeamByID(id);
            if (team == null) return null;
            try
            {
                _context.TeamInfo.Remove(team);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        // @author: Ishani Saxena
        public int? UpdateTeam(TeamInfo team)
        {
            var teamToUpdate = this.GetTeamByID(team.Id);
            if (teamToUpdate == null)
                return null;
            teamToUpdate.fullName = team.fullName;
            teamToUpdate.collegeProgram = team.collegeProgram;
            teamToUpdate.birthdate = team.birthdate;
            teamToUpdate.yearInProgram = team.yearInProgram;
            try
            {
                _context.TeamInfo.Update(teamToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
            
        }

        // @author: Ishani Saxena
        public int? Add(TeamInfo team)
        {
            var getTeam = _context.TeamInfo.Where(x => x.fullName.Equals(team.fullName) && x.birthdate.Equals(team.birthdate)).FirstOrDefault();
            if(getTeam != null)
            {
                return null;
            }
            try
            {
                _context.TeamInfo.Add(team);
                _context.SaveChanges();
                return 1;

            }
            catch (Exception)
            {
                return 0;
            }
        }

    }
}
