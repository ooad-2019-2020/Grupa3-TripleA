using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Bibliotekar: Osoba
    {
        List<string> dodaniCitati = new List<string>();
        List<Knjiga> knjigeIzSedmicnePreporuke = new List<Knjiga>();
        List<KnjigaZahtjev> zahtjeviZaIznajmljivanje = new List<KnjigaZahtjev>();


        public List<string> DodaniCitati { get => dodaniCitati; set => dodaniCitati = value; }
        public List<Knjiga> KnjigeIzSedmicnePreporuke { get => knjigeIzSedmicnePreporuke; set => knjigeIzSedmicnePreporuke = value; }
        public List<KnjigaZahtjev> ZahtjeviZaIznajmljivanje { get => zahtjeviZaIznajmljivanje; set => zahtjeviZaIznajmljivanje = value; }
    }
}
