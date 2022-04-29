using FinalProject_Group1.Data;
using FinalProject_Group1.Interfaces;
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
    public class FavoriteFoodsController : ControllerBase
    {
       
        private readonly ILogger<FavoriteFoodsController> _logger;
        //private readonly TeamInfoContext _context;
        private readonly IFavoriteFoodsContextDAO _context;

        public FavoriteFoodsController(ILogger<FavoriteFoodsController> logger, IFavoriteFoodsContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllFavoriteFoodss());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var food = _context.GetFavoriteFoodsByID(id);
            if (food == null)
            {
                return NotFound(id);
            }
            return Ok(food);
        }
    }
}
