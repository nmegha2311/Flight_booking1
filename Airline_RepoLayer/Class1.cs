using Customer_Entities;
using Flight_Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Airline_RepoLayer
{
    public class DepotContext : DbContext
    {
        public DepotContext(DbContextOptions<DepotContext> options) : base(options)
        {


        }
        public DbSet<Class2> Flights { get; set; }
        public DbSet<Flight> Flights_header { get; set; }
    }

   
    public class Repo
    {
        private readonly DepotContext _depocontext;

        public Repo(DepotContext depotcontext)
        {
            _depocontext = depotcontext;
        }
        public void Airline(Class2 Flight_details, Flight Flight_header)
        {
            _depocontext.Flights.Add(Flight_details);
            _depocontext.Flights_header.Add(Flight_header);
            _depocontext.SaveChanges();


        }

        public void AddAirline(Flight Flight_header)
        {
            _depocontext.Flights_header.Add(Flight_header);
            _depocontext.SaveChanges();
        }

        public void Block(string Airline)
        {
            (from s in _depocontext.Flights_header where s.Airline == Airline select s).ToList().ForEach(x=>x.isActive="no");
            _depocontext.SaveChanges();
        }

        public List<Flight> getAirline()
        {
            var list=(from s in _depocontext.Flights_header where s.isActive=="yes" select s).ToList();
            return list;
            
        }
    }
}
