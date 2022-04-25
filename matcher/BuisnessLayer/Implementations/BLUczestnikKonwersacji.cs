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
    class BLUczestnikKonwersacji : IUczestnikKonwersacji
    {
        private readonly IUnitOfWork uow;
        public BLUczestnikKonwersacji(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public UczestnikKonwersacji AddUczestnikKonwersacji(UczestnikKonwersacji uczestnik)
        {
            var _uczestnikKonwersacji = uow.Uczestnik.GetUczestnik(uczestnik.UczestnikKonwersacji_Id);
            if (_uczestnikKonwersacji == null)
            {
                _uczestnikKonwersacji = new UczestnikKonwersacji();


                uow.Uczestnik.AddUczestnikKonwersacji(_uczestnikKonwersacji);
            }
            uow.Complete();
            return _uczestnikKonwersacji;
        }

        public bool DeleteUczestnik(int id)
        {
            if (id <= default(int))
            {
                throw new ArgumentException("Invalid konwersacja id");
            }
            var isremoved = uow.Uczestnik.DeleteUczestnik(id);
            if (isremoved) uow.Complete();
            return isremoved;
        }

        public IEnumerable<UczestnikKonwersacji> GetUczestnicy()
        {
            return uow.Uczestnik.GetUczestnicy();
        }

        public UczestnikKonwersacji GetUczestnik(int id)
        {
            return uow.Uczestnik.GetUczestnik(id);
        }
    }
}
