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
        public int Id { set; get; }
        public string Imie { set; get; }
        public int plec_Id { set; get; }
        public string Opis { set; get; }

        public string Email { set; get; }

        public string Haslo { set; get; }
    }
}
