using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class BibliotekarDb
    {
        int id;
        ICollection<String> dodaniCitati;
        ICollection<Knjiga> knjigeIzSedmicnePreporuke;
        ICollection<KnjigaZahtjev> zahtjeviZaIznajmljivanje;
        string ime, prezime, email, lozinka;
        [Display(Name = "Bibliotekar")]
        public int Id { get => id; set => id = value; }
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression("^(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{5,10})$", ErrorMessage = "Pasword mora imati 5 do 10 karaktera od kojih mora biti barem jedno slovo i barem jedna cifra!")]
        public string Lozinka { get => lozinka; set => lozinka = value; }
        [Display(Name = "Ime")]
        [RegularExpression("^([a-zA-Z])+?$", ErrorMessage = "Polje ne smije sadržavati znakove osim slova")]
        public string Ime { get => ime; set => ime = value; }
        [RegularExpression("^([a-zA-Z])+?$", ErrorMessage = "Polje ne smije sadržavati znakove osim slova")]
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }

        [NotMapped]
        public ICollection<String> DodaniCitati { get => dodaniCitati; set => dodaniCitati = value; }
        public ICollection<Knjiga> KnjigeIzSedmicnePreporuke { get => knjigeIzSedmicnePreporuke; set => knjigeIzSedmicnePreporuke = value; }
        [NotMapped]
        public ICollection<KnjigaZahtjev> ZahtjeviZaIznajmljivanje { get => zahtjeviZaIznajmljivanje; set => zahtjeviZaIznajmljivanje = value; }
    }
}
