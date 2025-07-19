using Microsoft.AspNetCore.Mvc;
using RacingDigital.Models;
using System.Collections.Generic;
using System.Collections;
using RacingDigital.Services.Interfaces;

namespace RacingDigital.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RacesController : ControllerBase
    {
      

        private readonly ILogger<RacesController> _logger;
        private IRacesService _racesService;

        public RacesController(ILogger<RacesController> logger, IRacesService racesService)
        {
            _logger = logger;
            _racesService = racesService;
        }

        [HttpGet]
        public IEnumerable<RaceResult> GetRaces()
        {
            return _racesService.GetRaces();
        }

    }

   
}
