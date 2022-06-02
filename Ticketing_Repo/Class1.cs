using Customer_Entities;
using Microsoft.EntityFrameworkCore;
using System;

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


        }

    }
}
