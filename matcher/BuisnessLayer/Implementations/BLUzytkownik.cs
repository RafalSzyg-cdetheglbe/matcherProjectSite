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
    class BLUzytkownik : IUzytkownik
    {
        private readonly IUnitOfWork uow;
        public BLUzytkownik(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public bool AddPlecToUser(int uzytkownikId, int plecId)
        {
            if (uzytkownikId <= default(int))
                throw new ArgumentException("Invalid user id");
            if (plecId <= default(int))
                throw new ArgumentException("Invalid plec id");

            if (uow.Plec.GetPlec(plecId) == null)
                throw new InvalidOperationException("Invalid plec");

            if (uow.Uzytkownik.GetUzytkownik(uzytkownikId) == null)
                throw new InvalidOperationException("Invalid user");

            var uzytkownikPlec = uow.Plec.GetPlec(uzytkownikId);

          

            uow.Plec.AddPlecToUser(uzytkownikId, plecId);
            uow.Complete();

            return true;
        }

        public void AddUzytkownik(Uzytkownik uzytkownik)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Uzytkownik> GetUzytkownicy()
        {
            throw new NotImplementedException();
        }

        public Uzytkownik GetUzytkownik(int id)
        {
            throw new NotImplementedException();
        }
    }
}
