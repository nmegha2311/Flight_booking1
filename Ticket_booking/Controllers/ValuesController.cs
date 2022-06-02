using Customer_Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticket_booking.ModelEntities;
using Ticketing_ManagerLayer;

namespace Ticket_booking.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Search _depocontext;
        public ValuesController(Search search)
        {
            _depocontext = search;
        }

        // POST api/values
        [HttpPost("/api/values")]
        public IActionResult Post([FromBody] ModelEntities.ModelEntities11 item)
        {
            Customer_Details obj1 = new Customer_Details();
            obj1.Emailid = item.Emailid;
            obj1.RName = item.RName;
            obj1.SeatNumbers = item.SeatNumbers;
            obj1.meal = item.meal;
            obj1.age = item.age;
            obj1.Flight_Number = item.Flight_Number;
           

            Customer_Header obj2 = new Customer_Header();
            obj2.Emailid = item.Emailid;
            obj2.Name = item.Name;
            obj2.Nos = item.Nos;
            Random R = new Random();
            obj1.PNR_number = "PNR_"+R.Next(1000,5000);
           _depocontext.Insert(obj1, obj2);

            return Ok(obj1.PNR_number.ToString());


        }



        // PUT api/values/5
      
        [HttpGet("/api/values/{PNR}")]
        public IActionResult SearchbyPNR(string PNR)
        {

            List<ModelEntities1> list = _depocontext.SearchbyPNR(PNR);

            return Ok(list);

        }

        // DELETE api/values/5
        [HttpDelete("/api/cancel/{emailid}")]
        public void Delete(string emailid)
        {
            Customer_Header obj2 = new Customer_Header();

            Customer_Details obj1 = new Customer_Details();

            obj2.Emailid = emailid;
            _depocontext.Delete(emailid);
        }

        [HttpGet("/api/discount/{dis}")]
        public bool Discount(string dis)
        {
            Discount disc = new Discount();
           bool a= _depocontext.discount(dis);
            return a;
        }
    }
}
