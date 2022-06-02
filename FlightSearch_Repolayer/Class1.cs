using Flight_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ModelEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlightSearch_Repolayer
{
    public class Depotcontext : DbContext
    {
        public Depotcontext(DbContextOptions<Depotcontext> options) : base(options)
        {


        }

        public DbSet<Class2> Flights { get; set; }
        public DbSet<Flight> Flights_header { get; set; }


    }


    public class Repo
    {
        private readonly Depotcontext _depocontext;

        public Repo(Depotcontext depotcontext)
        {
            _depocontext = depotcontext;
        }

        public List<ModelEntities1> SearchFlight(string fro, string to)
        {
            //return _depocontext.Flights.OrderBy(e => e.From_Place == from).ToList();
            List<ModelEntities1> model = new List<ModelEntities1>();
           var list = (from s in _depocontext.Flights join std in _depocontext.Flights_header on s.Flight_number equals std.Flightno where s.From_Place == fro & s.To_Place == to & std.isActive=="yes" select new { Airline = std.Airline, Flightno=std.Flightno, From=s.From_Place,to=s.To_Place,cost=s.cost,start=s.Startdatetime,end=s.EndDateTime}).ToList();
            foreach(var p in list)
            {
                ModelEntities1 obj = new ModelEntities1();
                obj.From_Place = p.From;
                obj.To_Place = p.to;
                obj.cost = p.cost;
                obj.Startdatetime = p.start;
                obj.EndDateTime = p.end;
                obj.Airline = p.Airline;
                obj.Flightno = p.Flightno;
                model.Add(obj);
            }
            
            return model;
        }
        public List<ModelEntities1> SearchbyFlightDate(DateTime date)
        {
            List<ModelEntities1> model = new List<ModelEntities1>();
            var list = (from s in _depocontext.Flights join std in _depocontext.Flights_header on s.Flight_number equals std.Flightno where (s.Startdatetime).ToLongDateString() == date.ToLongDateString()
                         select new{ Airline = std.Airline, Flightno = std.Flightno, From = s.From_Place, to = s.To_Place, cost = s.cost, start = s.Startdatetime, end = s.EndDateTime }).ToList();
         
            foreach (var p in list)
            {
                ModelEntities1 obj = new ModelEntities1();
                obj.From_Place = p.From;
                obj.To_Place = p.to;
                obj.cost = p.cost;
                obj.Startdatetime = p.start;
                obj.EndDateTime = p.end;
                obj.Airline = p.Airline;
                obj.Flightno = p.Flightno;
                model.Add(obj);
            }
            return model;
        }
    }
}
