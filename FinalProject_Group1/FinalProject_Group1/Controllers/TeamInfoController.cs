using FinalProject_Group1.Data;
using FinalProject_Group1.Interfaces;
using FinalProject_Group1.Models;
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

    // @author: Ishani Saxena
    public class TeamInfoController : ControllerBase
    {
       
        private readonly ILogger<TeamInfoController> _logger;
        private readonly ITeamInfoContextDAO _context;
        // @author: Ishani Saxena
        public TeamInfoController(ILogger<TeamInfoController> logger, ITeamInfoContextDAO context)
        {
            _logger = logger;
            _context = context;
        }
        // @author: Ishani Saxena
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllTeamInfos());
        }
        // @author: Ishani Saxena
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
        // @author: Ishani Saxena
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
        // @author: Ishani Saxena
        [HttpPut]
        public IActionResult Put(TeamInfo team)
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
        // @author: Ishani Saxena
        [HttpPost]
        public IActionResult Post(TeamInfo team)
        {
            var result = _context.Add(team);

            if (result == null)
            {
                return StatusCode(500, "Item already exists!");
            }
            if(result == 0)
            {
                return StatusCode(500, "An error occurred.");
            }

            return Ok();
        }
    }
}
