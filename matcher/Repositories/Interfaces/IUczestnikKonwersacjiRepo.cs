using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DB;

namespace Repositories.Interfaces
{
   public interface IUczestnikKonwersacjiRepo
    {
        public void AddUczestnikKonwersacji(UczestnikKonwersacji uczestnik);
        public IEnumerable<UczestnikKonwersacji> GetUczestnicy();
        public bool DeleteUczestnik(int id);
        public UczestnikKonwersacji GetUczestnik(int id);
    }
}
