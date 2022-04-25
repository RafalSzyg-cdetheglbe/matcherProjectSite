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
    class BLWiadomosc : IWiadomosc
    {
        private readonly IUnitOfWork uow;
        public BLWiadomosc(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public Wiadomosc AddWiadomosc(Wiadomosc wiadomosc)
        {
            var _wiadomosc = uow.Wiadomosc.GetWiadomosc(wiadomosc.Wiadomosc_Id);
            if (_wiadomosc == null)
            {
                _wiadomosc = new Wiadomosc();

                uow.Wiadomosc.AddWiadomosc(_wiadomosc);
            }
            uow.Complete();
            return _wiadomosc;
        }

        public bool DeleteWiadomosc(int id)
        {
            if (id <= default(int))
            {
                throw new ArgumentException("Invalid konwersacja id");
            }
            var isremoved = uow.Wiadomosc.DeleteWiadomosc(id);
            if (isremoved) uow.Complete();
            return isremoved;
        }

        public Wiadomosc GetWiadomosc(int id)
        {
            return uow.Wiadomosc.GetWiadomosc(id);
        }

        public IEnumerable<Wiadomosc> GetWiadomosci()
        {
            return uow.Wiadomosc.GetWiadomosci();
        }
    }
}
