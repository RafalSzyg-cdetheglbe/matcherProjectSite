using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DB;

namespace Repositories.Interfaces
{
    interface IPlecRepo
    {
        public void AddPlec(Plec plec);
        public IEnumerable<Plec> GetPlci();
        public bool DeletePlec(int id);
        public Plec GetPlec(int id);
    }
}
