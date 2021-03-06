﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Bibliotekar: Osoba
    {
        ICollection<String> dodaniCitati;
        ICollection<Knjiga> knjigeIzSedmicnePreporuke;
        ICollection<KnjigaZahtjev> zahtjeviZaIznajmljivanje;

        [NotMapped]
        public ICollection<String> DodaniCitati { get => dodaniCitati; set => dodaniCitati = value; }
        public ICollection<Knjiga> KnjigeIzSedmicnePreporuke { get => knjigeIzSedmicnePreporuke; set => knjigeIzSedmicnePreporuke = value; }
        [NotMapped]
        public ICollection<KnjigaZahtjev> ZahtjeviZaIznajmljivanje { get => zahtjeviZaIznajmljivanje; set => zahtjeviZaIznajmljivanje = value; }
    }
}
