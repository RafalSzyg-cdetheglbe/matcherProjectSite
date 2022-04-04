using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Konwersacja
{
    [Table("UczestnikKonwersacji")]
    public class UczestnikKonwersacji
    {
        public int Id { set; get; }
        public int Konwersacja_Id { set; get; }
        public int Uzytkownik_Id { set; get; }
    }
}
