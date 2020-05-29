using System;
using System.Collections.Generic;

namespace BiblitekaAPI
{
    public partial class Recenzija
    {
        public int Id { get; set; }
        public string TekstRecenzije { get; set; }
        public int BrojZvjezdica { get; set; }
        public DateTime DatumObjave { get; set; }
        public int? KnjigaId { get; set; }
        public bool NeprimjerenSadrzaj { get; set; }
        public int? KorisnikId { get; set; }

        public virtual Knjiga Knjiga { get; set; }
        public virtual Osoba Korisnik { get; set; }
    }
}
