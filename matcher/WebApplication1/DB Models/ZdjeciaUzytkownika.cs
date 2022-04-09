using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DB
{
    [Table("ZdjeciaUzytkownika")]
    public class ZdjeciaUzytkownika
    {
        [Column("Id")]
        public int ZdjeciaUzytkownika_Id { set; get; }
        [Column("Uzytkownik")]
        public int Uzytkownik_Id { set; get; }
        [Column("Link")]
        public string Link { set; get; }
    }
}
