using System;
using static Login_RepoLayer.Depotcontext;
using LoginEntities;

namespace Login_ManagerLayer
{
    public class Search
    {
        private readonly Repo _depocontext;
        public Search(Repo depotcontext)
        {
            _depocontext = depotcontext;
        }

        public bool Login(Class1 obj)
        {
           bool login= _depocontext.Login(obj);
            return login;
        }
        public bool User(Class1 obj)
        {
            bool login = _depocontext.User(obj);
            return login;
        }

        public void Register(string username, string password)
        {
            _depocontext.Register(username, password);
        }

    }
}
