using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class KnjigaZahtjev
    {
        ObicniKorisnik korisnik;
        Knjiga knjiga;
        DateTime datum;

        public ObicniKorisnik Korisnik { get => korisnik; set => korisnik = value; }
        public Knjiga Knjiga { get => knjiga; set => knjiga = value; }
        public DateTime Datum { get => datum; set => datum = value; }
    }
}
