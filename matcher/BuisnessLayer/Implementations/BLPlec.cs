using BuisnessLayer.Interfaces;
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
        public void AddPlec(Plec plec)
        {
            throw new NotImplementedException();
        }

        public bool AddPlecToUser(int uzytkownikId, int plecId)
        {
            throw new NotImplementedException();
        }

        public bool DeletePlec(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plec> GetPlci()
        {
            throw new NotImplementedException();
        }

        public Plec GetPlec(int id)
        {
            throw new NotImplementedException();
        }
    }
}
