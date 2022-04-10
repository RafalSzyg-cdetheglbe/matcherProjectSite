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
  public  class PlecRepo : IPlecRepo
    {
        private readonly MatcherDB matcherDb;

        public PlecRepo(MatcherDB matcherDb)
        {
            this.matcherDb = matcherDb;
        }
        public void AddPlec(Plec plec)
        {
            matcherDb.Plci.Add(plec);
        }

        public bool DeletePlec(int id)
        {
            bool wynik = false;
            Plec toDelete = GetPlec(id);
            if (toDelete != null)
            {
                wynik = true;
                matcherDb.Plci.Remove(toDelete);
            }
            return wynik;

        }

        public IEnumerable<Plec> GetPlci()
        {
            return matcherDb.Plci;
        }

        public Plec GetPlec(int id)
        {
            return matcherDb.Plci.Where(p => p.Plec_Id == id).FirstOrDefault();
        }
    }
}
