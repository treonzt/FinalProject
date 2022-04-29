using FinalProject_Group1.Data;
using FinalProject_Group1.Data3;
using FinalProject_Group1.Interfaces3;
using FinalProject_Group1.Models3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FinalProject_Group1.Interfaces3.ITeamInfoContextDao3;

namespace FinalProject_Group1.Data3
{
    //author: avery ingram
    public class TeamInfoContextDAO3 : ITeamInfoContextDAO3
    {
        private TeamInfoContext3 _context3;
        //author: avery ingram
        public TeamInfoContextDAO3(TeamInfoContext3 context3)
        {
            _context3 = context3;
        }

        //author: avery ingram
        public List<TeamInfo3> GetAllTeamInfos()
        {
            return _context3.TeamInfo3.ToList();
        }

        //author: avery ingram
        public TeamInfo3 GetTeamByID(int id)
        {
            return _context3.TeamInfo3.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        //author: avery ingram
        public int? RemoveTeamById(int id)
        {
            var team3 = this.GetTeamByID(id);
            if (team3 == null) return null;
            try
            {
                _context3.TeamInfo3.Remove(team3);
                _context3.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        //author: avery ingram
        public int? UpdateTeam(TeamInfo3 team3)
        {
            var teamToUpdate = this.GetTeamByID(team3.Id);
            if (teamToUpdate == null)
                return null;
            teamToUpdate.fullName = team3.fullName;
            teamToUpdate.favoriteSport = team3.favoriteSport;
            teamToUpdate.favoriteTeam = team3.favoriteTeam;
            teamToUpdate.favoritePlayer = team3.favoritePlayer;
            try
            {
                _context3.TeamInfo3.Update(teamToUpdate);
                _context3.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        //author: avery ingram
        public int? Add(TeamInfo3 team3)
        {
            var getTeam = _context3.TeamInfo3.Where(x => x.fullName.Equals(team3.fullName) && x.favoriteSport.Equals(team3.favoriteSport)).FirstOrDefault();
            if (getTeam != null)
            {
                return null;
            }
            try
            {
                _context3.TeamInfo3.Add(team3);
                _context3.SaveChanges();
                return 1;

            }
            catch (Exception)
            {
                return 0;
            }
        }

    }
}