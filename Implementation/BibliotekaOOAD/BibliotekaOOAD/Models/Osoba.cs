using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Osoba
    {
        int id;
        string ime, prezime, email, lozinka;
        [Required(ErrorMessage = "Polje je obavezno")]
        [Display(Name = "Korisnik")]
        public int Id { get => id; set => id = value; }
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression("^(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{5,10})$", ErrorMessage = "Pasword mora imati 5 do 10 karaktera od kojih mora biti barem jedno slovo i barem jedna cifra!")]
        public string Lozinka { get => lozinka; set => lozinka = value; }
        [Required(ErrorMessage = "Polje Ime je obavezno")]
        [Display(Name = "Ime")]
        [RegularExpression("^([a-zA-Z])+?$", ErrorMessage = "Polje ne smije sadržavati znakove osim slova")]
        public string Ime { get => ime; set => ime = value; }
        [RegularExpression("^([a-zA-Z])+?$", ErrorMessage = "Polje ne smije sadržavati znakove osim slova")]
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        
        
    }
}
