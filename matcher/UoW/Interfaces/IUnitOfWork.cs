using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IUzytkownikRepo Uzytkownik { get; }
        IKonwersacjaRepo Konwersacja { get; }
        IPlecRepo Plec { get; }
        IUczestnikKonwersacjiRepo Uczestnik{get;}
        IWiadomoscRepo Wiadomosc { get; }
        IZainteresowaniePlciaRepo ZainteresowaniePlcia { get; }

        IZdjeciaUzytkownikaRepo Zdjecie { get; }

        Task<int> CompleteAsync();
        int Complete();

    }
}
