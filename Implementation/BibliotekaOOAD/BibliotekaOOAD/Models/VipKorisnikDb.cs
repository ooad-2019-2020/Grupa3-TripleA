using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class VipKorisnikDb
    {
        int id;
        ICollection<IKnjiga> zatrazeneKnjigeZaDodavanje;
        decimal ostvareniPopust;
        [Range(minimum: 0, maximum: 100, ErrorMessage = "Popust moze biti od 0 do 100%!")]
        public decimal OstvareniPopust { get => ostvareniPopust; set => ostvareniPopust = value; }
        internal ICollection<IKnjiga> ZatrazeneKnjigeZaDodavanje { get => zatrazeneKnjigeZaDodavanje; set => zatrazeneKnjigeZaDodavanje = value; }

        string korisnickoIme;
        Racun racun = new Racun();
        IKnjiga trenutnoIznajmljenjaKnjiga;
        DateTime datumRodjenja;
        ICollection<Obavjestenje> obavjestenja;
        ICollection<IKnjiga> procitaneKnjige;
        DateTime krajVazenjaClanarine;

        string ime, prezime, email, lozinka;
        [Display(Name = "Vip Korisnik")]
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

        [RegularExpression("^[A-Za-z0-9_-]*$", ErrorMessage = "Korisnicko ime smije sadrzavati samo slova i cifre!")]
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public Racun Racun { get => racun; set => racun = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public DateTime KrajVazenjaClanarine { get => krajVazenjaClanarine; set => krajVazenjaClanarine = value; }
        public ICollection<Obavjestenje> Obavjestenja { get => obavjestenja; set => obavjestenja = value; }
        internal IKnjiga TrenutnoIznajmljenjaKnjiga { get => trenutnoIznajmljenjaKnjiga; set => trenutnoIznajmljenjaKnjiga = value; }
        internal ICollection<IKnjiga> ProcitaneKnjige1 { get => procitaneKnjige; set => procitaneKnjige = value; }

        public decimal dajDodatak()
        {
            return 0;
        }

        public Knjiga dajKnjigu()
        {
            return null;
        }

        public void update()
        {
            return;
        }
    }
}
