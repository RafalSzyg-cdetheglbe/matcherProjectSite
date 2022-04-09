using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DB
{
    [Table("Konswersacja")]
    public class Konwersacja
    {
        [Column("Id")]
        [Key]
        public int Konwersacja_Id { set; get; }
        [Column("Uczestnik")]
        public ICollection<UczestnikKonwersacji> { set; get; }


    }
}
