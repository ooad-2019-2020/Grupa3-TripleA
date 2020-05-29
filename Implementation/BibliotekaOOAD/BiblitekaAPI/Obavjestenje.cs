using System;
using System.Collections.Generic;

namespace BiblitekaAPI
{
    public partial class Obavjestenje
    {
        public int Id { get; set; }
        public string Tekst { get; set; }
        public int? PosiljaocId { get; set; }
        public int? PrimaocId { get; set; }
        public DateTime DatumSlanja { get; set; }
        public int? ObicniKorisnikDbId { get; set; }
        public int? ObicniKorisnikId { get; set; }

        public virtual Osoba ObicniKorisnik { get; set; }
        public virtual ObicniKorisnik ObicniKorisnikDb { get; set; }
        public virtual Osoba Posiljaoc { get; set; }
        public virtual Osoba Primaoc { get; set; }
    }
}
