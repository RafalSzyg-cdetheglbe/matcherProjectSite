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
    class BLKonwersacja : IKonwersacja
    {
        private readonly IUnitOfWork uow;
        public BLKonwersacja(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public Konwersacja AddKonwersacja(Konwersacja konwersacja)
        {
            var _konwersacja = uow.Konwersacja.Get_Konwersacja(konwersacja.Konwersacja_Id);
            if (_konwersacja == null)
            {
                _konwersacja = new Konwersacja();
                uow.Konwersacja.AddKonwersacja(_konwersacja);
            }
            uow.Complete();
            return _konwersacja;
        }

        public bool DeleteKonwersacja(int id)
        {
            if(id <= default(int))
            {
                throw new ArgumentException("Invalid konwersacja id");
            }
            var isremoved = uow.Konwersacja.DeleteKonwersacja(id);
            if (isremoved) uow.Complete();
            return isremoved;
        }

        public IEnumerable<Konwersacja> GetKonwersacje()
        {
            return uow.Konwersacja.GetKonwersacje();
        }

        public Konwersacja Get_Konwersacja(int id)
        {
            return uow.Konwersacja.Get_Konwersacja(id);
        }
    }
}
