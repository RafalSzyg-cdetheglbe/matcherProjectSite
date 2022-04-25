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
    class BLZdjeciaUzytkownika : IZdjeciaUzytkownika
    {
        private readonly IUnitOfWork uow;
        public BLZdjeciaUzytkownika(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public ZdjeciaUzytkownika AddZdjecie(ZdjeciaUzytkownika zdjecie)
        {
            var _zdjecie = uow.Zdjecie.GetZdjecie(zdjecie.ZdjeciaUzytkownika_Id);
            if (_zdjecie == null)
            {
                _zdjecie = new ZdjeciaUzytkownika();

                uow.Zdjecie.AddZdjecie(_zdjecie);
            }
            uow.Complete();
            return _zdjecie;
        }

        public bool DeleteZdjecie(int id)
        {
            if (id <= default(int))
            {
                throw new ArgumentException("Invalid konwersacja id");
            }
            var isremoved = uow.ZainteresowaniePlcia.DeleteZainteresowanie(id);
            if (isremoved) uow.Complete();
            return isremoved;
        }

        public IEnumerable<ZdjeciaUzytkownika> GetZdjecia()
        {
            return uow.Zdjecie.GetZdjecia();
        }

        public ZdjeciaUzytkownika GetZdjecie(int id)
        {
            return uow.Zdjecie.GetZdjecie(id);
        }
    }
}
