using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DB;

namespace BuisnessLayer.Interfaces
{
    interface IKonwersacja
    {
        public Konwersacja AddKonwersacja(Konwersacja konwersacja);
        public IEnumerable<Konwersacja> GetKonwersacje();
        public bool DeleteKonwersacja(int id);
        public Konwersacja Get_Konwersacja(int id);
    }
}
