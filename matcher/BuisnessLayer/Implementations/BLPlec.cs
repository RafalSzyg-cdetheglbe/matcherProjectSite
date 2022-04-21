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
    class BLPlec : IPlec
    {
        private readonly IUnitOfWork uow;
        public BLPlec(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public Plec AddPlec(Plec plec)
        {
            var _plec = uow.Plec.GetPlec(plec.Plec_Id);
            if (_plec == null)
            {
                _plec = new Plec
                {
                    Nazwa = _plec.Nazwa
                };
                uow.Plec.AddPlec(_plec);
            }
            uow.Complete();
            return _plec;
        }

        public bool AddPlecToUser(int uzytkownikId, int plecId)
        {
            throw new NotImplementedException();
        }

        public bool DeletePlec(int id)
        {
            if (id <= default(int))
            {
                throw new ArgumentException("Invalid konwersacja id");
            }
            var isremoved = uow.Plec.DeletePlec(id);
            if (isremoved) uow.Complete();
            return isremoved;
        }

        public IEnumerable<Plec> GetPlci()
        {
            return uow.Plec.GetPlci();
        }

        public Plec GetPlec(int id)
        {
            return uow.Plec.GetPlec(id);
        }
    }
}
