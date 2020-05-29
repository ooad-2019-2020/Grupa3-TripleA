using System;
using System.Collections.Generic;

namespace BiblitekaAPI
{
    public partial class Knjiga
    {
        public Knjiga()
        {
            Recenzija = new HashSet<Recenzija>();
            Zanr = new HashSet<Zanr>();
        }

        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Autor { get; set; }
        public string Opis { get; set; }
        public decimal Rating { get; set; }
        public int? KorisnikKojiJePosudioId { get; set; }
        public int? BibliotekarDbId { get; set; }

        public virtual Bibliotekar BibliotekarDb { get; set; }
        public virtual Osoba KorisnikKojiJePosudio { get; set; }
        public virtual ICollection<Recenzija> Recenzija { get; set; }
        public virtual ICollection<Zanr> Zanr { get; set; }
    }
}
