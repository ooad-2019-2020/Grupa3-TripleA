using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Biblioteka : IPratilac, IKorisnik
    {
        Gost gost;
        ICollection<Osoba> clanovi;
        ICollection<Knjiga> knjige;
        Administrator administrator;
        string info;
        IKorisnik factory;
        ICollection<IPratilac> pratioci;

        public Gost Gost { get => gost; set => gost = value; }
        public ICollection<Osoba> Clanovi { get => clanovi; set => clanovi = value; }
        public ICollection<Knjiga> Knjige { get => knjige; set => knjige = value; }
        public Administrator Administrator { get => administrator; set => administrator = value; }
        [Required(ErrorMessage = "Info mora biti dostupan")]
        public string Info { get => info; set => info = value; }
        internal IKorisnik Factory { get => factory; set => factory = value; }
        internal ICollection<IPratilac> Pratioci { get => pratioci; set => pratioci = value; }

        public Osoba dajKorisnika()
        {
            return null;
        }

        public void update()
        {
            return;
        }
    }
}
