using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DB;

namespace BuisnessLayer.Interfaces
{
    interface IPlec
    {
        public Plec AddPlec(Plec plec);
        public IEnumerable<Plec> GetPlci();
        public bool DeletePlec(int id);
        public Plec GetPlec(int id);

        public bool AddPlecToUser(int uzytkownikId, int plecId);
    }
}
