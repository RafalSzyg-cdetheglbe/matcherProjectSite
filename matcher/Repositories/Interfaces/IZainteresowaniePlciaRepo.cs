using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DB;

namespace Repositories.Interfaces
{
    interface IZainteresowaniePlciaRepo
    {
        public void AddZainteresowaniePlcia(ZainteresowaniePlcia zainteresowanieplacia);
        public IEnumerable<ZainteresowaniePlcia> GetZainteresowania();
        public bool DeleteZainteresowanie(int id);

        public ZainteresowaniePlcia GetZainteresowanie(int id);
    }
}
