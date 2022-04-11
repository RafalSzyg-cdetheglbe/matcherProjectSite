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

        public Uzytkownik AddUzytkownik(Uzytkownik uzytkownik)
        {
            if (uzytkownik == null)
                throw new ArgumentException("Invalid uzytkownik details");


            var _uzytkownik = uow.Uzytkownik.GetUzytkownik(uzytkownik.Uzytkownik_Id);
            if (_uzytkownik == null)
            {
                _uzytkownik = new Uzytkownik
                {
                    Imie = uzytkownik.Imie
                };
                uow.Uzytkownik.AddUzytkownik(uzytkownik);
            }
            else
            {
                _uzytkownik.Imie = uzytkownik.Imie;
            }

            uow.Complete();

            return _uzytkownik;
        }

        public bool DeleteUzytkownik(int id)
        {
            if (id <= default(int))
                throw new ArgumentException("Invalid uzytkownik id");

            var isremoved = uow.Uzytkownik.DeleteUser(id);
            if (isremoved)
                uow.Complete();

            return isremoved;
        }

        public IEnumerable<Uzytkownik> GetUzytkownicy()
        {
            return uow.Uzytkownik.GetUzytkownicy();
        }

        public Uzytkownik GetUzytkownik(int id)
        {
            if (id <= default(int))
                throw new ArgumentException("Invalid uzytkownik id");

            return uow.Uzytkownik.GetUzytkownik(id);
        }
    }
}

