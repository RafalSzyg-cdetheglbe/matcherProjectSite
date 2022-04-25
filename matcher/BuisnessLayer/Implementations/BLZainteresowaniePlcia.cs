using BuisnessLayer.Interfaces;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DB;

namespace BuisnessLayer.Implementations
{
    class BLZainteresowaniePlcia : IZainteresowaniePlacia
    {
        private readonly IUnitOfWork uow;
        public BLZainteresowaniePlcia(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public ZainteresowaniePlcia AddZainteresowaniePlcia(ZainteresowaniePlcia zainteresowanieplacia)
        {
            var _zainteresowaieplcia = uow.ZainteresowaniePlcia.GetZainteresowanie(zainteresowanieplacia.ZainteresowaniePlcia_Id);
            if (_zainteresowaieplcia == null)
            {
                _zainteresowaieplcia = new ZainteresowaniePlcia();

                uow.ZainteresowaniePlcia.AddZainteresowaniePlcia(_zainteresowaieplcia);
            }
            uow.Complete();
            return _zainteresowaieplcia;
        }

        public bool DeleteZainteresowanie(int id)
        {
            if (id <= default(int))
            {
                throw new ArgumentException("Invalid konwersacja id");
            }
            var isremoved = uow.ZainteresowaniePlcia.DeleteZainteresowanie(id);
            if (isremoved) uow.Complete();
            return isremoved;
        }

        public IEnumerable<ZainteresowaniePlcia> GetZainteresowania()
        {
            return uow.ZainteresowaniePlcia.GetZainteresowania();
        }

        public ZainteresowaniePlcia GetZainteresowanie(int id)
        {
            return uow.ZainteresowaniePlcia.GetZainteresowanie(id);
        }
    }
}
