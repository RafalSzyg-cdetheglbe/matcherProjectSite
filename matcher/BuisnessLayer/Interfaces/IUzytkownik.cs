using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DB;

namespace BuisnessLayer.Interfaces
{
  public  interface IUzytkownik
    {
        public Uzytkownik AddUzytkownik(Uzytkownik uzytkownik);
        public IEnumerable<Uzytkownik> GetUzytkownicy();
        public bool DeleteUzytkownik(int id);
        public Uzytkownik GetUzytkownik(int id);
    }
}
