using FinalProject_Group1.Data;
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
    public class TeamInfoController : ControllerBase
    {
       
        private readonly ILogger<TeamInfoController> _logger;
        private readonly TeamInfoContext _context;
        public TeamInfoController(ILogger<TeamInfoController> logger, TeamInfoContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.TeamInfo.ToList());
        }
    }
}
