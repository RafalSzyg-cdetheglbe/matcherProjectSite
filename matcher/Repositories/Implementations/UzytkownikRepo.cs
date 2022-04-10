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
   public class UzytkownikRepo : IUzytkownikRepo
    {
        private readonly MatcherDB matcherDb;

       public UzytkownikRepo(MatcherDB matcherdb)
        {
            this.matcherDb = matcherdb;
        }
        public void AddUzytkownik(Uzytkownik uzytkownik)
        {
            matcherDb.Uzytkownicy.Add(uzytkownik);
        }

        public bool DeleteUser(int id)
        {
            bool wynik = false;
            Uzytkownik toDelete = GetUzytkownik(id);
            if (toDelete != null)
            {
                wynik = true;
                matcherDb.Uzytkownicy.Remove(toDelete);
            }
            return wynik;
        }

        public IEnumerable<Uzytkownik> GetUzytkownicy()
        {
            return matcherDb.Uzytkownicy;
        }

        public Uzytkownik GetUzytkownik(int id)
        {
            return matcherDb.Uzytkownicy.Where(u => u.Uzytkownik_Id == id).FirstOrDefault();
        }
    }
}
