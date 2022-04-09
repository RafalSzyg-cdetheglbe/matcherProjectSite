using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.DB
{
    [Table("Uzytkownik")]
    public class Uzytkownik 
    {
        [Column("Id")]
        public int Uzytkownik_Id { set; get; }
        [Column("Imie")]
        public string Imie { set; get; }
       
        public int ZainteresowaniaPlcia_Id { set; get; }

        [Column("Zainteresowania Plcia")]
        [ForeignKey(nameof(ZainteresowaniaPlcia_Id))]
        public ZainteresowaniePlcia ZainteresowaniePlcia { set; get; }

        
        [Column("Plcie")]
        public ICollection<Plec>plcie { set; get; }

        public int Konwersacja_Id { set; get; }

        [Column("Konwersacja")]
        [ForeignKey(nameof(Konwersacja_Id))]
        public Konwersacja Konwersacja { set; get; }
        public int UczestnikKonwersacji_Id { set; get; }

        [Column("Uczestnicy")]
       [ForeignKey(nameof(UczestnikKonwersacji_Id))]
        public UczestnikKonwersacji Uczestnik { set; get; }

        [Column("Opis")]
        public string Opis { set; get; }

        [Column("Email")]
        public string Email { set; get; }
        [Column("Haslo")]
        public string Haslo { set; get; }
    }
}
