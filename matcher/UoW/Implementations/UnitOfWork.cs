using Matcher;
using Repositories.Interfaces;
using Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UoW.Implementations
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly MatcherDB matcherDB;
        public UnitOfWork(MatcherDB matcherdb)
        {
            this.matcherDB = matcherdb;
        }
        private IUzytkownikRepo _Uzytkownik;
        public IUzytkownikRepo Uzytkownik
        {
            get
            {
                if (this._Uzytkownik == null)
                {
                    this._Uzytkownik = new UzytkownikRepo(matcherDB);
                }
                return this._Uzytkownik;
            }

        }

        private IKonwersacjaRepo _Konwersacja;
        public IKonwersacjaRepo Konwersacja
        {
            get
            {
                if (this._Konwersacja == null)
                {
                    this._Konwersacja = new KonwersacjaRepo(matcherDB);
                }
                return this._Konwersacja;
            }

        }

        private IPlecRepo _Plec;
        public IPlecRepo Plec
        {
            get
            {
                if (this._Plec == null)
                {
                    this._Plec = new PlecRepo(matcherDB);
                }
                return this._Plec;
            }

        }

        private IUczestnikKonwersacjiRepo _Uczestnik;
        public IUczestnikKonwersacjiRepo Uczestnik
        {
            get
            {
                if (this._Uczestnik == null)
                {
                    this._Uczestnik = new UczestnikKonwersacjiRepo(matcherDB);
                }
                return this._Uczestnik;
            }

        }


        private IWiadomoscRepo _Wiadomosc;
        public IWiadomoscRepo Wiadomosc
        {
            get
            {
                if (this._Wiadomosc == null)
                {
                    this._Wiadomosc = new WiadomoscRepo(matcherDB);
                }
                return this._Wiadomosc;
            }

        }

        private IZainteresowaniePlciaRepo _ZainteresowaniePlcia;
        public IZainteresowaniePlciaRepo ZainteresowaniePlcia
        {
            get
            {
                if (this._ZainteresowaniePlcia == null)
                {
                    this._ZainteresowaniePlcia = new ZainteresowaniePlciaRepo(matcherDB);
                }
                return this._ZainteresowaniePlcia;
            }

        }
        private IZdjeciaUzytkownikaRepo _Zdjecie;
        public IZdjeciaUzytkownikaRepo Zdjecie
        {
            get
            {
                if (this._Zdjecie == null)
                {
                    this._Zdjecie = new ZdjeciaUzytkownikaRepo(matcherDB);
                }
                return this._Zdjecie;
            }

        }


        public int Complete()
        {
            return matcherDB.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await matcherDB.SaveChangesAsync();
        }



    }
}
