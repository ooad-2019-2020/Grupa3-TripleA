using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Recenzija
    {
        string tekstRecenzije;
        int brojZvjezdica;
        DateTime datumObjave;
        Knjiga knjiga;
        ObicniKorisnik korisnik;
        bool neprimjerenSadrzaj;

        public string TekstRecenzije { get => tekstRecenzije; set => tekstRecenzije = value; }
        public int BrojZvjezdica { get => brojZvjezdica; set => brojZvjezdica = value; }
        public DateTime DatumObjave { get => datumObjave; set => datumObjave = value; }
        public Knjiga Knjiga { get => knjiga; set => knjiga = value; }
        public bool NeprimjerenSadrzaj { get => neprimjerenSadrzaj; set => neprimjerenSadrzaj = value; }
        public ObicniKorisnik Korisnik { get => korisnik; set => korisnik = value; }
    }
}
