using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BibliotekaOOAD.Models
{
    public class AdministratorDb
    {
        int id;
        int brojLoginova;

        public int BrojLoginova { get => brojLoginova; set => brojLoginova = value; }
        string ime, prezime, email, lozinka;
        [Display(Name = "Administrator")]
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


    }
}

