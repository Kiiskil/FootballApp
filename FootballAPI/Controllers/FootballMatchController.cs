using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FootballAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FootballMatchController : ControllerBase
    {
        private readonly ILogger<FootballMatchController> _logger;

        public FootballMatchController(ILogger<FootballMatchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult GetAllMatches(){
            return Ok();
        }
        
    }
}
