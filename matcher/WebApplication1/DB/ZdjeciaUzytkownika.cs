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
        public int Id { set; get; }
        public int Uzytkownik_Id { set; get; }
        public string Link { set; get; }
    }
}
