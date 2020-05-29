using System;
using System.Collections.Generic;

namespace BiblitekaAPI
{
    public partial class KnjigaZahtjev
    {
        public int? KorisnikId { get; set; }
        public int? KnjigaId { get; set; }
        public DateTime Datum { get; set; }

        public virtual Knjiga Knjiga { get; set; }
        public virtual Osoba Korisnik { get; set; }
    }
}
