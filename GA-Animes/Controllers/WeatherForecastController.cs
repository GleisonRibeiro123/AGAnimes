using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Data.Requests;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GA_Animes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IAnimeAppService _animeService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IAnimeAppService animeService)
        {
            _logger = logger;
            _animeService = animeService;
        }

        [HttpGet]
        public async Task<IActionResult> FindAnimes([FromQuery] FindAnimesRequest request)
        {
            try
            {
                return Ok(_animeService.FindAnimes(new FindAnimesRequest { }));
            }
            catch (Exception ex)
            {
                return null;
            }
        }
     }
}
