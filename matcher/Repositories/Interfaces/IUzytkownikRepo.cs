using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DB;

namespace Repositories.Interfaces
{
   public interface IUzytkownikRepo
    {
        public void AddUzytkownik(Uzytkownik uzytkownik);
        public IEnumerable<Uzytkownik> GetUzytkownicy();
        public bool DeleteUser(int id);
        public Uzytkownik GetUzytkownik(int id);
    }
}
