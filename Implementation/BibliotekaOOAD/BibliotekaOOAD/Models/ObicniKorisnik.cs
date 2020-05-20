using System;
using System.Collections.Generic;

namespace BibliotekaOOAD.Models
{

        public class ObicniKorisnik : IPratilac, IKnjiga, IPlacanjeDodatak
        {
            string korisnickoIme;
            Racun racun = new Racun();
            IKnjiga trenutnoIznajmljenjaKnjiga;
            DateTime datumRodjenja;
            List<Obavjestenje> obavjestenja = new List<Obavjestenje>();
            List<IKnjiga> procitaneKnjige = new List<IKnjiga>();
            DateTime krajVazenjaClanarine;

        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public Racun Racun { get => racun; set => racun = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public List<Obavjestenje> Obavjestenja { get => obavjestenja; set => obavjestenja = value; }
        public DateTime KrajVazenjaClanarine { get => krajVazenjaClanarine; set => krajVazenjaClanarine = value; }
        internal IKnjiga TrenutnoIznajmljenjaKnjiga { get => trenutnoIznajmljenjaKnjiga; set => trenutnoIznajmljenjaKnjiga = value; }
        internal List<IKnjiga> ProcitaneKnjige { get => procitaneKnjige; set => procitaneKnjige = value; }

        public decimal dajDodatak()
        {
            return 0;
        }

        public Knjiga dajKnjigu()
        {
            return null;
        }

        public void update()
        {
            return;
        }
    }
}