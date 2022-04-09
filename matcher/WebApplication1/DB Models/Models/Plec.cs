using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DB
{
    [Table("Plec")]
    public class Plec
    {
        [Column("Id")]
        public int Plec_Id { set; get; }
        [Column("Nazwa")]
        public int Uzytkownik_Id { set; get; }

        [ForeignKey (nameof(Uzytkownik_Id))]
        public Uzytkownik Uzytkownik { set; get; }

        public ICollection<Plec> Nazwa { set; get; }
    }
}
