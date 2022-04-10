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
    class ZainteresowaniePlciaRepo : IZainteresowaniePlciaRepo
    {
        private readonly MatcherDB matcherDb;

        ZainteresowaniePlciaRepo(MatcherDB matcherbd)
        {
            this.matcherDb = matcherbd;
        }
        public void AddZainteresowaniePlcia(ZainteresowaniePlcia zainteresowanieplacia)
        {
            matcherDb.ZainteresowaniaPlciami.Add(zainteresowanieplacia);
        }

        public bool DeleteZainteresowanie(int id)
        {
            bool wynik = false;
            ZainteresowaniePlcia toDelete = GetZainteresowanie(id);
            if (toDelete != null)
            {
                wynik = true;
                matcherDb.ZainteresowaniaPlciami.Remove(toDelete);
            }
            return wynik;
        }


        public IEnumerable<ZainteresowaniePlcia> GetZainteresowania()
        {
            return matcherDb.ZainteresowaniaPlciami;
        }

        public ZainteresowaniePlcia GetZainteresowanie(int id)
        {
            return matcherDb.ZainteresowaniaPlciami.Where(z => z.ZainteresowaniePlcia_Id == id).FirstOrDefault();
        }
    }
}
