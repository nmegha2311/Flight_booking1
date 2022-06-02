using Customer_Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using static Ticketing_RepoLayer.Class1;
using System.Data;
using System.Linq;
using ModelEntities;

namespace Ticketing_RepoLayer
{
    public class Class1
    {
        public class Depotcontext : DbContext
        {
            public Depotcontext(DbContextOptions<Depotcontext> options) : base(options)
            {


            }

            public DbSet<Customer_Details> customer_Details { get; set; }
            public DbSet<Customer_Header> Customer_Header { get; set; }
            public DbSet<Discount> Discounts { get; set; }

        }

    }

    public class Repo
    {
        private readonly Depotcontext _depocontext;

        public Repo(Depotcontext depotcontext)
        {
            _depocontext = depotcontext;
        }

        public void Insert(Customer_Details obj1, Customer_Header obj2)
        {
            var list = (from s in _depocontext.Customer_Header where s.Emailid == obj2.Emailid select s).ToList();
            if (list.Count > 0)
            {
                _depocontext.customer_Details.Add(obj1);
            }
            else
            {
                _depocontext.Customer_Header.Add(obj2);
                _depocontext.customer_Details.Add(obj1);
                
            }
            _depocontext.SaveChanges();

        }

        public List<ModelEntities1> SearchbyPNR(string PNR)
        {
            List<ModelEntities1> model = new List<ModelEntities1>();

            var list = (from s in _depocontext.customer_Details join std in _depocontext.Customer_Header on s.Emailid equals std.Emailid where s.PNR_number==PNR  select new { Email = s.Emailid, Nos = std.Nos, Name = s.RName, Seatnumber = s.SeatNumbers, PNR = s.PNR_number, Flight_number = s.Flight_Number }).ToList();
            foreach(var i in list)
            {
                ModelEntities1 obj1 = new ModelEntities1();
               
                obj1.Emailid = i.Email.ToString();
                obj1.Nos = i.Nos;
                obj1.PNR_number = i.PNR;
                obj1.RName = i.Name;
                obj1.SeatNumbers = i.Seatnumber;
                obj1.Flightno = i.Flight_number;
                model.Add(obj1);
            }
            
            return model;
        }

        public void delete(string emailid)
        {
            var list=(from s in _depocontext.Customer_Header where s.Emailid==emailid select s).ToList();
            var list1 = (from s in _depocontext.customer_Details where s.Emailid == emailid select s).ToList();
            foreach (var item in list1)
            {
                
                _depocontext.customer_Details.Remove(item);
                _depocontext.SaveChanges();
            }
            foreach (var item in list)
            {
                
                _depocontext.Customer_Header.Remove(item);
                _depocontext.SaveChanges();
            }
        }

        public bool discount(string dis)
        {
            bool a = false;
            var list = (from s in _depocontext.Discounts where s.discount == dis select s).ToList();
           if( list.Count > 0)
            {
                 a = true;

            }
            return a;
        }
    }
}
