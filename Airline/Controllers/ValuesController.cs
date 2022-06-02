using Airline.Model;
using Airline_ManagerLayer;
using Microsoft.AspNetCore.Mvc;
using Flight_Entities;
using Customer_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airline.Controllers
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
        [HttpPost("/api/values")]
        public IActionResult Post([FromBody] ModelEntities1 item)
        {
            Flight_Entities.Class2 obj = new Flight_Entities.Class2();
            
            obj.From_Place = item.from_place;
            obj.To_Place = item.to_place;
            obj.Startdatetime = item.startdate;
            obj.EndDateTime = item.Enddate;
            obj.Scheduledays = item.scheduledays;
            obj.Instrumentused = item.Instrument;
            obj.Business = item.business;
            obj.non_business = item.non_business;
            obj.cost = item.cost;
            obj.rows = item.rows;
            obj.meal = item.meal;
            obj.Flight_number = item.Flightno;
          
           
            Flight_Entities.Flight obj1 = new Flight_Entities.Flight();
            obj1.Flightno = item.Flightno;
            obj1.Airline = item.Airline;
            obj1.isActive = item.isActive;

            _depocontext.AddAirline(obj,obj1);
            return Ok("Sucessfully inserted the airline details ");
        }

        [HttpPost("/api/values/Airline")]
        public IActionResult Airline([FromBody] ModelEntities1 item)
        {
            Flight_Entities.Flight obj1 = new Flight_Entities.Flight();
            obj1.Flightno = item.Flightno;
            obj1.Airline = item.Airline;
            obj1.isActive = item.isActive;
            _depocontext.Airline(obj1);
            return Ok("Sucessfully inserted the airline details ");
        }


            [HttpGet("/api/values/get")]
        public IActionResult getAirline()
        {
            List<Flight> list = new List<Flight>();
            list=_depocontext.getAirline();
            return Ok(list);
        }
        [HttpPut("/api/values/{Airline}")]
        public IActionResult BlockAirline(string Airline, [FromBody] ModelEntities1 values)
        {
            Flight_Entities.Flight obj1 = new Flight_Entities.Flight();
            obj1.isActive = values.isActive;
            _depocontext.Block(Airline);
            return Ok("Blocked Airline");
        }
       
    }
}
