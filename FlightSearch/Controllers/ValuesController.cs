using FightSearch_ManagerLayer;
using Flight_Entities;
using FlightSearch_Repolayer;
using Microsoft.AspNetCore.Mvc;
using System;
using ModelEntities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightSearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Search _depocontext;
        public ValuesController(Search search)
        {
            _depocontext = search;
        }

      
        [HttpGet("/api/values/{from}/{to}")]
        public IActionResult  SearchbyFlightPlace(string from, string to)
        
        {

            List<ModelEntities1> list = _depocontext.SearchFlight(from ,to);
           
            
            
            
            return Ok(list);

        }
        [HttpGet("/api/values/{Date}")]
        public IActionResult SearchbyFlightDate(DateTime Date)
        {

            List<ModelEntities1> list = _depocontext.SearchbyFlightDate(Date);
           


            return Ok(list);

        }

    }
}
