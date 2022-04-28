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

namespace FinalProject_Group1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    // @author: Zach Treon
    public class TeamInfoController2 : ControllerBase
    {

        private readonly ILogger<TeamInfoController2> _logger;
        private readonly ITeamInfoContextDAO2 _context2;
        // @author: Zach Treon
        public TeamInfoController2(ILogger<TeamInfoController2> logger, ITeamInfoContextDAO2 context)
        {
            _logger = logger;
            _context = context;
        }
        // @author: Zach Treon
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllTeamInfos());
        }
        // @author: Zach Treon
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var team = _context.GetTeamByID(id);
            if (team == null)
            {
                return NotFound(id);
            }
            return Ok(team);
        }
        // @author: Zach Treon
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveTeamById(id);
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
        // @author: Zach Treon
        [HttpPut]
        public IActionResult Put(TeamInfo2 team)
        {
            var result = _context.UpdateTeam(team);
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
        // @author: Zach Treon
        [HttpPost]
        public IActionResult Post(TeamInfo2 team)
        {
            var result = _context.Add(team);

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