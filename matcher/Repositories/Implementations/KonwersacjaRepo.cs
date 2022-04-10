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
   public class KonwersacjaRepo : IKonwersacjaRepo
    {
        private readonly MatcherDB matcherDb;

       public KonwersacjaRepo(MatcherDB matcherbd)
        {
            this.matcherDb = matcherbd;
        }
        public void AddKonwersacja(Konwersacja konwersacja)
        {
            matcherDb.Konwersacje.Add(konwersacja);
        }

        public bool DeleteKonwersacja(int id)
        {
            bool wynik = false;
            Konwersacja toDelete = Get_Konwersacja(id);
            if (toDelete != null)
            {
                wynik = true;
                matcherDb.Konwersacje.Remove(toDelete);
            }
            return wynik;

        }

        public IEnumerable<Konwersacja> GetKonwersacje()
        {
            return matcherDb.Konwersacje;
        }

        public Konwersacja Get_Konwersacja(int id)
        {
            return matcherDb.Konwersacje.Where(k => k.Konwersacja_Id == id).FirstOrDefault();
        }
    }
}
