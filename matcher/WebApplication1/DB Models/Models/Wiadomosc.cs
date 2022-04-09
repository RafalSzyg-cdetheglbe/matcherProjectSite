using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Konwersacja
{
    [Table("Wiadomosc")]
    public class Wiadomosc
    {
        [Column("Id")]
        public int Wiadomosc_Id { set; get; }
        [Column("Uczestnik")]
        public int Uczestnik_Id { set; get; }
        [Column("Tresc")]
        public string Tresc { set; get; }
        [Column("Czas")]
        public DateTime czas { set; get; }
    }
}
