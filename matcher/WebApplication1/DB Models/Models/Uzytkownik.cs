using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Konwersacja;

namespace WebApplication1.DB
{
    [Table("Uzytkownik")]
    public class Uzytkownik 
    {
        [Column("Id")]
        public int Uzytkownik_Id { set; get; }
        [Column("Imie")]
        public string Imie { set; get; }
       
        [Column("Zainteresowania Plcia")]
        public ICollection<ZainteresowaniePlcia> zainteresowaniaPlcia{ set; get; }

        [Column("Plcie")]
        public ICollection<Plec>plcie { set; get; }

        [Column("Konwersacje")]
        public ICollection<Konwersacja> Konwersacja { set; get; }
        [Column("Uczestnicy")]
        public ICollection<UczestnikKonwersacji> Uczestnicy { set; get; }

        [Column("Opis")]
        public string Opis { set; get; }

        [Column("Email")]
        public string Email { set; get; }
        [Column("Haslo")]
        public string Haslo { set; get; }
    }
}
