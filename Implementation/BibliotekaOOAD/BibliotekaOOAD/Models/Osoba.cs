using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Osoba
    {
        int id;
        string ime, prezime, email, lozinka;

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
    }
}
