using Flight_Entities;
using FlightSearch_Repolayer;
using ModelEntities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace FightSearch_ManagerLayer
{
    public class Search
    {
        private readonly Repo _depocontext;
        public Search(Repo depotcontext)
        {
            _depocontext = depotcontext;
        }

        public List<ModelEntities1> SearchFlight(string first,string to)
        {
            List<ModelEntities1> list;
          list = _depocontext.SearchFlight(first,to);
            return list;

        }

        public List<ModelEntities1> SearchbyFlightDate(DateTime date)
        {
            List<ModelEntities1> list;
            list = _depocontext.SearchbyFlightDate(date);
            return list;
        }
    }
}

    

