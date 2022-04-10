using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DB;

namespace Matcher
{
    public class MatcherDB : DbContext
    {
        public DbSet<Uzytkownik> Uzytkownicy { set; get; }
        public DbSet<Konwersacja> Konwersacje { set; get; }
        public DbSet<Plec> Plci { set; get; }
        public DbSet<UczestnikKonwersacji>UczestnicyKonwersacji{set;get;}
        public DbSet<Wiadomosc> Wiadomosci { set; get; }
        public DbSet<ZainteresowaniePlcia> ZainteresowaniaPlciami { set; get; }
        public DbSet<ZdjeciaUzytkownika> ZdjeciaUzytkownika { set; get; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                  .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MatcherDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
