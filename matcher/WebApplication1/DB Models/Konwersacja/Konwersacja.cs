using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Konwersacja
{
    [Table("Konswersacja")]
    public class Konwersacja
    {
        public int Id { set; get; }
        public int Uczestnik_Id { set; get; }


    }
}
