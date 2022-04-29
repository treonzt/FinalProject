using Microsoft.AspNetCore.Mvc;
using FinalProject_Group1.Data2;
using FinalProject_Group1.Interfaces2;
using FinalProject_Group1.Models2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FinalProject_Group1.Interfaces3.ITeamInfoContextDao3;
using FinalProject_Group1.Models3;

namespace FinalProject_Group1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    //author: Avery Ingram
    public class TeamInfoController3 : ControllerBase
    {

        private readonly ILogger<TeamInfoController3> _logger;
        private readonly ITeamInfoContextDAO3 _context3;
        //author: Avery Ingram
        public TeamInfoController3(ILogger<TeamInfoController3> logger, ITeamInfoContextDAO3 context)
        {
            _logger = logger;
            _context3 = context;
        }
        //author: Avery Ingram
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context3.GetAllTeamInfos());
        }
        //author: Avery Ingram
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var team = _context3.GetTeamByID(id);
            if (team == null)
            {
                return NotFound(id);
            }
            return Ok(team);
        }
        //author: Avery Ingram
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context3.RemoveTeamById(id);
            if (result == null)
            {
                return NotFound(id);
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occurred.");
            }

            return Ok();
        }
        //author: Avery Ingram
        [HttpPut]
        public IActionResult Put(TeamInfo3 team)
        {
            var result = _context3.UpdateTeam(team);
            if (result == null)
            {
                return NotFound(team.Id);
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occurred.");
            }

            return Ok();

        }
        //author: Avery Ingram
        [HttpPost]
        public IActionResult Post(TeamInfo3 team)
        {
            var result = _context3.Add(team);

            if (result == null)
            {
                return StatusCode(500, "Item already exists!");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occurred.");
            }

            return Ok();
        }
    }
}
