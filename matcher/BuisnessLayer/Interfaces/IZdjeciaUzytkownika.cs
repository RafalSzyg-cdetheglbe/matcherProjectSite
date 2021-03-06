using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DB;

namespace BuisnessLayer.Interfaces
{
    interface IZdjeciaUzytkownika
    {
        public ZdjeciaUzytkownika AddZdjecie(ZdjeciaUzytkownika zdjecie);
        public IEnumerable<ZdjeciaUzytkownika> GetZdjecia();
        public bool DeleteZdjecie(int id);
        public ZdjeciaUzytkownika GetZdjecie(int id);
    }
}
