using LoginEntities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Data;

namespace Login_RepoLayer
{
    public class Depotcontext:DbContext
    {
        public Depotcontext(DbContextOptions<Depotcontext> options) : base(options)
        {

            
        }

        public DbSet<Class1> Login { get; set; }
       

        public class Repo
        {
            private readonly Depotcontext _depocontext;

            public Repo(Depotcontext depotcontext)
            {
                _depocontext = depotcontext;
            }

            public bool Login(Class1 obj)
            {
                bool a = false;
                var list = (from s in _depocontext.Login where s.Username == obj.Username & s.Password == obj.Password & s.Admin=="Y" select s).ToList();
                if (list.Count > 0)
                {
                    a = true;
                   
                }
                return a;
            }
            public bool User(Class1 obj)
            {
                bool a = false;
                var list = (from s in _depocontext.Login where s.Username == obj.Username & s.Password == obj.Password select s).ToList();
                if (list.Count > 0)
                {
                    a = true;

                }
                return a;
            }
            public void Register(string username, string password)
            {
                Class1 obj = new Class1();
                obj.Username = username;
                obj.Password = password;
                obj.Admin = "N";
                _depocontext.Add(obj);
                _depocontext.SaveChanges();
            }

        }
    }
}

