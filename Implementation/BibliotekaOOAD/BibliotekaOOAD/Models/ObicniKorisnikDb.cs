using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class ObicniKorisnikDb
    {
        int id;
        string korisnickoIme;
        Racun racun = new Racun();
        IKnjiga trenutnoIznajmljenjaKnjiga;
        DateTime datumRodjenja;
        ICollection<Obavjestenje> obavjestenja;
        ICollection<IKnjiga> procitaneKnjige;
        DateTime krajVazenjaClanarine;

        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public Racun Racun { get => racun; set => racun = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public DateTime KrajVazenjaClanarine { get => krajVazenjaClanarine; set => krajVazenjaClanarine = value; }
        public ICollection<Obavjestenje> Obavjestenja { get => obavjestenja; set => obavjestenja = value; }
        public int Id { get => id; set => id = value; }
        internal IKnjiga TrenutnoIznajmljenjaKnjiga { get => trenutnoIznajmljenjaKnjiga; set => trenutnoIznajmljenjaKnjiga = value; }
        internal ICollection<IKnjiga> ProcitaneKnjige1 { get => procitaneKnjige; set => procitaneKnjige = value; }

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
