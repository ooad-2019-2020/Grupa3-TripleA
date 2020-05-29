using System;
using System.Collections.Generic;

namespace BiblitekaAPI
{
    public partial class Racun
    {
        public Racun()
        {
            ObicniKorisnik = new HashSet<ObicniKorisnik>();
            Osoba = new HashSet<Osoba>();
        }

        public int Id { get; set; }
        public int BrojRacuna { get; set; }
        public decimal Stanje { get; set; }

        public virtual ICollection<ObicniKorisnik> ObicniKorisnik { get; set; }
        public virtual ICollection<Osoba> Osoba { get; set; }
    }
}
