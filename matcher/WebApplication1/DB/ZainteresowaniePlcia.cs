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
        public int Id { set; get; }
        public int Uzytkownik_Id { set; get; }
        public int Plec_Id{ set; get; }
    }
}
