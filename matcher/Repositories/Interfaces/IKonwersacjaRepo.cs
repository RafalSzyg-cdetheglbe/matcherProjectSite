using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DB;

namespace Repositories.Interfaces
{
    interface IKonwersacjaRepo
    {
        public void AddKonwersacja(Konwersacja konwersacja);
        public IEnumerable<Konwersacja> GetKonwersacje();
        public bool DeleteKonwersacja(int id);
        public Konwersacja Get_Konwersacja(int id);
    }
}
