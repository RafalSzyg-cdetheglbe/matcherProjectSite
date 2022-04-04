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
        public int Id { set; get; }
        public int Uczestnik_Id { set; get; }
        public string Tresc { set; get; }
        public DateTime czas { set; get; }
    }
}
