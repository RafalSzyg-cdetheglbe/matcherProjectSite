using Matcher;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DB;

namespace Repositories.Implementations
{
    class WiadomoscRepo : IWiadomoscRepo
    {
        private readonly MatcherDB matcherDb;

        WiadomoscRepo(MatcherDB matcherbd)
        {
            this.matcherDb = matcherbd;
        }

        public void AddWiadomosc(Wiadomosc wiadomosc)
        {
            matcherDb.Wiadomosci.Add(wiadomosc);
        }

        public bool DeleteWiadomosc(int id)
        {
            bool wynik = false;
            Wiadomosc toDelete = GetWiadomosc(id);
            if (toDelete != null)
            {
                wynik = true;
                matcherDb.Wiadomosci.Remove(toDelete);
            }
            return wynik;
        }

        public Wiadomosc GetWiadomosc(int id)
        {
            return matcherDb.Wiadomosci.Where(w => w.Wiadomosc_Id == id).FirstOrDefault();
        }

        public IEnumerable<Wiadomosc> GetWiadomosci()
        {
            return matcherDb.Wiadomosci;
        }
    }
}
