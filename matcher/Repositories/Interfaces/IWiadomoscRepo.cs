using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DB;

namespace Repositories.Interfaces
{
    interface IWiadomoscRepo
    {
        public void AddWiadomosc(Wiadomosc wiadomosc);
        public IEnumerable<Wiadomosc> GetWiadomosci();
        public bool DeleteWiadomosc(int id);
        public Wiadomosc GetWiadomosc(int id);
    }
}
