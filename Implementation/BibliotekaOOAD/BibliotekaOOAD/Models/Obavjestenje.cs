using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Obavjestenje
    {
        int id;
        string tekst;
        Osoba posiljaoc;
        Osoba primaoc;
        DateTime datumSlanja;

        public int Id { get => id; set => id = value; }
        [Required(ErrorMessage = "Obavjestenje mora sadrzavati tekst")]
        public string Tekst { get => tekst; set => tekst = value; }
        public Osoba Posiljaoc { get => posiljaoc; set => posiljaoc = value; }
        public Osoba Primaoc { get => primaoc; set => primaoc = value; }
        public DateTime DatumSlanja { get => datumSlanja; set => datumSlanja = value; }
    }
}
