using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DB
{
    [Table("UczestnikKonwersacji")]
    public class UczestnikKonwersacji
    {
        [Column("Id")]
        public int UczestnikKonwersacji_Id { set; get; }
        [Column("Konwersacja")]
        public ICollection<Konwersacja> Konwersacje{ set; get; }
        [Column("Uzytkownik")]
        public ICollection<Uzytkownik> Uzytkownicy{ set; get; }
        [Column("Wiadomosc")]
        public ICollection<Wiadomosc> Wiadomosci { set; get; }
    }
}
