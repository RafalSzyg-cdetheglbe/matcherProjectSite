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
        public int Id { set; get; }
        public Dictionary<IKey, Plec> Nazwa { set; get; }
    }
}
