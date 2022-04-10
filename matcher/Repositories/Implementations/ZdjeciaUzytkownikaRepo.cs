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
    class ZdjeciaUzytkownikaRepo : IZdjeciaUzytkownikaRepo
    {
        private readonly MatcherDB matcherDb;

        ZdjeciaUzytkownikaRepo(MatcherDB matcherbd)
        {
            this.matcherDb = matcherbd;
        }

        public void AddZdjecie(ZdjeciaUzytkownika zdjecie)
        {
            matcherDb.ZdjeciaUzytkownika.Add(zdjecie);
        }

        public bool DeleteZdjecie(int id)
        {
            bool wynik = false;
            ZdjeciaUzytkownika toDelete = GetZdjecie(id);
            if (toDelete != null)
            {
                wynik = true;
                matcherDb.ZdjeciaUzytkownika.Remove(toDelete);
            }
            return wynik;
        }

        public IEnumerable<ZdjeciaUzytkownika> GetZdjecia()
        {
            return matcherDb.ZdjeciaUzytkownika;
        }

        public ZdjeciaUzytkownika GetZdjecie(int id)
        {
            return matcherDb.ZdjeciaUzytkownika.Where(z => z.ZdjeciaUzytkownika_Id == id).FirstOrDefault();
        }
    }
}
