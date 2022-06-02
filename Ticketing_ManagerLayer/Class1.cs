using Customer_Entities;
using ModelEntities;
using System;
using System.Collections.Generic;
using Ticketing_RepoLayer;

namespace Ticketing_ManagerLayer
{
    public class Search
    {
        private readonly Repo _depocontext;
        

        public Search(Repo depotcontext)
        {
            _depocontext = depotcontext;
        }

        public void Insert(Customer_Details obj1, Customer_Header obj2)
        {
            _depocontext.Insert(obj1, obj2);
        }

        public List<ModelEntities1> SearchbyPNR(string PNR)
        {
            List<ModelEntities1> list = _depocontext.SearchbyPNR(PNR);
            return list;
        }

        public void Delete(string emailid)
        {
            _depocontext.delete(emailid);
        }

        public bool discount(string dis)
        {
           bool a= _depocontext.discount(dis);
            return a;
        }
    }
}
