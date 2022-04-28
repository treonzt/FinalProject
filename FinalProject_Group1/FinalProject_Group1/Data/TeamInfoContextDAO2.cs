using FinalProject_Group1.Data2;
using FinalProject_Group1.Interfaces2;
using FinalProject_Group1.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Group1.Data2
{
    // @author: Zach Treon
    public class TeamInfoContextDAO2 : ITeamInfoContextDAO2
    {
        private TeamInfoContext2 _context;
        // @author: Zach Treon 
        public TeamInfoContextDAO2(TeamInfoContext2 context)
        {
            _context = context;
        }

        // @author: Zach Treon
        public List<TeamInfo2> GetAllTeamInfos()
        {
            return _context.TeamInfo2.ToList();
        }

        // @author: Zach Treon
        public TeamInfo2 GetTeamByID(int id)
        {
            return _context.TeamInfo2.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        // @author: Zach Treon
        public int? RemoveTeamById(int id)
        {
            var team = this.GetTeamByID(id);
            if (team == null) return null;
            try
            {
                _context.TeamInfo2.Remove(team);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        // @author:  Zach Treon
        public int? UpdateTeam(TeamInfo2 team)
        {
            var teamToUpdate = this.GetTeamByID(team.Id);
            if (teamToUpdate == null)
                return null;
            teamToUpdate.fullName = team.fullName;
            teamToUpdate.favoriteColor = team.favoriteColor;
            teamToUpdate.favoriteAnimal = team.favoriteAnimal;
            teamToUpdate.favoriteDrink = team.favoriteDrink;
            try
            {
                _context.TeamInfo2.Update(teamToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        // @author: Zach Treon
        public int? Add(TeamInfo2 team)
        {
            var getTeam = _context.TeamInfo2.Where(x => x.fullName.Equals(team.fullName) && x.favoriteColor.Equals(team.favoriteColor)).FirstOrDefault();
            if (getTeam != null)
            {
                return null;
            }
            try
            {
                _context.TeamInfo2.Add(team);
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
