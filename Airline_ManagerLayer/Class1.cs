using Airline_RepoLayer;
using Customer_Entities;
using Flight_Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Airline_ManagerLayer
{

    public class Search
    {
        private readonly Repo _depocontext;
        public Search(Repo depotcontext)
        {
            _depocontext = depotcontext;
        }
        public void AddAirline(Class2 Flight_details,Flight Flight_header)
        {
            _depocontext.Airline(Flight_details,Flight_header);
        }

        public void Airline(Flight Fligh_header)
        {
            _depocontext.AddAirline(Fligh_header);
        }
        public void Block(string Airline)
        {
            _depocontext.Block(Airline);
        }
        public List<Flight> getAirline()
        {
           var list= _depocontext.getAirline();
            return list;


        }
    }
}
