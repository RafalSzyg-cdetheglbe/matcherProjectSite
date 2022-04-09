using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DB
{
    [Table("ZainteresowaniePlcia")]
    public class ZainteresowaniePlcia
    {
        [Column("Id")]
        public int ZainteresowaniePlcia_Id { set; get; }
        [Column("Uzytkownik")]
        public int Uzytkownik_Id { set; get; }
        [ForeignKey(nameof(Uzytkownik_Id))]
        public Uzytkownik Uzytkownik { get; set; }
        [Column("Plec")]
        public int Plec_Id{ set; get; }
        [ForeignKey(nameof(Plec_Id))]
        public Plec Plec { get; set; }
    }
}
