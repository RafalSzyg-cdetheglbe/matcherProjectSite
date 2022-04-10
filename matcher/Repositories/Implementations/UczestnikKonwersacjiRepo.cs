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
    class UczestnikKonwersacjiRepo : IUczestnikKonwersacjiRepo
    {
        private readonly MatcherDB matcherDb;

        UczestnikKonwersacjiRepo(MatcherDB matcherbd)
        {
            this.matcherDb = matcherbd;
        }

        public void AddUczestnikKonwersacji(UczestnikKonwersacji uczestnik)
        {
            matcherDb.UczestnicyKonwersacji.Add(uczestnik);
        }

        public bool DeleteUczestnik(int id)
        {
            bool wynik = false;
            UczestnikKonwersacji toDelete = GetUczestnik(id);
            if (toDelete != null)
            {
                wynik = true;
                matcherDb.UczestnicyKonwersacji.Remove(toDelete);
            }
            return wynik;
        }

        public UczestnikKonwersacji GetUczestnik(int id)
        {
            return matcherDb.UczestnicyKonwersacji.Where(u => u.UczestnikKonwersacji_Id == id).FirstOrDefault();
        }

        public IEnumerable<UczestnikKonwersacji> GetUczestnicy()
        {
            return matcherDb.UczestnicyKonwersacji;
        }
    }
}
